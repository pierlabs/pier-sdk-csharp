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
        /// Alterar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Altera uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse AlterarUsingPUT11 (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
  
        /// <summary>
        /// Alterar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Altera uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> AlterarUsingPUT11WithHttpInfo (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
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
        TelefoneEstabelecimentoResponse AlterarUsingPUT13 (long? id, string ddd, string telefone, string ramal = null);
  
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
        ApiResponse<TelefoneEstabelecimentoResponse> AlterarUsingPUT13WithHttpInfo (long? id, string ddd, string telefone, string ramal = null);
        
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
        TerminalResponse AlterarUsingPUT15 (long? id, TerminalUpdate terminalUpdate);
  
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
        ApiResponse<TerminalResponse> AlterarUsingPUT15WithHttpInfo (long? id, TerminalUpdate terminalUpdate);
        
        /// <summary>
        /// Alterar Credor
        /// </summary>
        /// <remarks>
        /// Altera um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <param name="credorUpdate">credorUpdate</param>
        /// <returns>CredorResponse</returns>
        CredorResponse AlterarUsingPUT5 (long? id, CredorDTO credorUpdate);
  
        /// <summary>
        /// Alterar Credor
        /// </summary>
        /// <remarks>
        /// Altera um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <param name="credorUpdate">credorUpdate</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> AlterarUsingPUT5WithHttpInfo (long? id, CredorDTO credorUpdate);
        
        /// <summary>
        /// Cadastrar Credor
        /// </summary>
        /// <remarks>
        /// Cadastra um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <returns>CredorResponse</returns>
        CredorResponse CadastrarUsingPOST2 (CredorDTO credorPersist);
  
        /// <summary>
        /// Cadastrar Credor
        /// </summary>
        /// <remarks>
        /// Cadastra um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> CadastrarUsingPOST2WithHttpInfo (CredorDTO credorPersist);
        
        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse CadastrarUsingPOST3 (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
  
        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> CadastrarUsingPOST3WithHttpInfo (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <returns>CredorResponse</returns>
        CredorResponse ConsultarUsingGET11 (long? id);
  
        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <returns>ApiResponse of CredorResponse</returns>
        ApiResponse<CredorResponse> ConsultarUsingGET11WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>EstabelecimentoResponse</returns>
        EstabelecimentoResponse ConsultarUsingGET15 (long? id);
  
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        ApiResponse<EstabelecimentoResponse> ConsultarUsingGET15WithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <returns>PessoaJuridicaResponse</returns>
        PessoaJuridicaResponse ConsultarUsingGET20 (long? id);
  
        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        ApiResponse<PessoaJuridicaResponse> ConsultarUsingGET20WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        TelefoneEstabelecimentoResponse ConsultarUsingGET26 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        ApiResponse<TelefoneEstabelecimentoResponse> ConsultarUsingGET26WithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse ConsultarUsingGET28 (long? id);
  
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> ConsultarUsingGET28WithHttpInfo (long? id);
        
        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Lista credores cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param>
        /// <param name="nome">Nome do credor (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>PageCredorResponse</returns>
        PageCredorResponse ListarUsingGET14 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
  
        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Lista credores cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param>
        /// <param name="nome">Nome do credor (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>ApiResponse of PageCredorResponse</returns>
        ApiResponse<PageCredorResponse> ListarUsingGET14WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
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
        /// <returns>PageEstabelecimentoResponse</returns>
        PageEstabelecimentoResponse ListarUsingGET19 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);
  
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
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        ApiResponse<PageEstabelecimentoResponse> ListarUsingGET19WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);
        
        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas
        /// </summary>
        /// <remarks>
        /// Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>PagePessoaJuridicaResponse</returns>
        PagePessoaJuridicaResponse ListarUsingGET24 (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
  
        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas
        /// </summary>
        /// <remarks>
        /// Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        ApiResponse<PagePessoaJuridicaResponse> ListarUsingGET24WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
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
        PageTelefoneEstabelecimentoResponse ListarUsingGET33 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
  
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
        ApiResponse<PageTelefoneEstabelecimentoResponse> ListarUsingGET33WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
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
        PageTerminalResponse ListarUsingGET35 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
  
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
        ApiResponse<PageTerminalResponse> ListarUsingGET35WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
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
        TelefoneEstabelecimentoResponse SalvarUsingPOST19 (long? idEstabelecimento, string ddd, string telefone, string ramal = null);
  
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
        ApiResponse<TelefoneEstabelecimentoResponse> SalvarUsingPOST19WithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param>
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <returns>TerminalResponse</returns>
        TerminalResponse SalvarUsingPOST21 (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual);
  
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param>
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <returns>ApiResponse of TerminalResponse</returns>
        ApiResponse<TerminalResponse> SalvarUsingPOST21WithHttpInfo (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Alterar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Altera uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> AlterarUsingPUT11Async (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);

        /// <summary>
        /// Alterar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Altera uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> AlterarUsingPUT11AsyncWithHttpInfo (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
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
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarUsingPUT13Async (long? id, string ddd, string telefone, string ramal = null);

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
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarUsingPUT13AsyncWithHttpInfo (long? id, string ddd, string telefone, string ramal = null);
        
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
        System.Threading.Tasks.Task<TerminalResponse> AlterarUsingPUT15Async (long? id, TerminalUpdate terminalUpdate);

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
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, TerminalUpdate terminalUpdate);
        
        /// <summary>
        /// Alterar Credor
        /// </summary>
        /// <remarks>
        /// Altera um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <param name="credorUpdate">credorUpdate</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> AlterarUsingPUT5Async (long? id, CredorDTO credorUpdate);

        /// <summary>
        /// Alterar Credor
        /// </summary>
        /// <remarks>
        /// Altera um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <param name="credorUpdate">credorUpdate</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, CredorDTO credorUpdate);
        
        /// <summary>
        /// Cadastrar Credor
        /// </summary>
        /// <remarks>
        /// Cadastra um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> CadastrarUsingPOST2Async (CredorDTO credorPersist);

        /// <summary>
        /// Cadastrar Credor
        /// </summary>
        /// <remarks>
        /// Cadastra um credor.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> CadastrarUsingPOST2AsyncWithHttpInfo (CredorDTO credorPersist);
        
        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> CadastrarUsingPOST3Async (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);

        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <returns>Task of CredorResponse</returns>
        System.Threading.Tasks.Task<CredorResponse> ConsultarUsingGET11Async (long? id);

        /// <summary>
        /// Consultar credor
        /// </summary>
        /// <remarks>
        /// Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of EstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET15Async (long? id);

        /// <summary>
        /// Consultar estabelecimento por id
        /// </summary>
        /// <remarks>
        /// Consulta os detalhes de um determinado estabelecimento
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET15AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaResponse> ConsultarUsingGET20Async (long? id);

        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica
        /// </summary>
        /// <remarks>
        /// Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>Task of TelefoneEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarUsingGET26Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarUsingGET26AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET28Async (long? id);

        /// <summary>
        /// Apresenta os dados de um determinado Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET28AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Lista credores cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param>
        /// <param name="nome">Nome do credor (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PageCredorResponse</returns>
        System.Threading.Tasks.Task<PageCredorResponse> ListarUsingGET14Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);

        /// <summary>
        /// Listar credores
        /// </summary>
        /// <remarks>
        /// Lista credores cadastrados. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param>
        /// <param name="nome">Nome do credor (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PageCredorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageCredorResponse>> ListarUsingGET14AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
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
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET19Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);

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
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET19AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null);
        
        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas
        /// </summary>
        /// <remarks>
        /// Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarUsingGET24Async (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);

        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas
        /// </summary>
        /// <remarks>
        /// Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarUsingGET24AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null);
        
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
        System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarUsingGET33Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);

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
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarUsingGET33AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null);
        
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
        System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET35Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);

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
        System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET35AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null);
        
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
        System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarUsingPOST19Async (long? idEstabelecimento, string ddd, string telefone, string ramal = null);

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
        System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarUsingPOST19AsyncWithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null);
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param>
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <returns>Task of TerminalResponse</returns>
        System.Threading.Tasks.Task<TerminalResponse> SalvarUsingPOST21Async (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual);

        /// <summary>
        /// Realiza o cadastro de um novo Terminal
        /// </summary>
        /// <remarks>
        /// Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param>
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarUsingPOST21AsyncWithHttpInfo (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual);
        
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
        /// Alterar Pessoa Jur\u00C3\u00ADdica Altera uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param> 
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse AlterarUsingPUT11 (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = AlterarUsingPUT11WithHttpInfo(id, razaoSocial, inscricaoEstadual, contato, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Pessoa Jur\u00C3\u00ADdica Altera uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param> 
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > AlterarUsingPUT11WithHttpInfo (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT11");
            
            // verify the required parameter 'razaoSocial' is set
            if (razaoSocial == null)
                throw new ApiException(400, "Missing required parameter 'razaoSocial' when calling EstabelecimentoApi->AlterarUsingPUT11");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Alterar Pessoa Jur\u00C3\u00ADdica Altera uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> AlterarUsingPUT11Async (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await AlterarUsingPUT11AsyncWithHttpInfo(id, razaoSocial, inscricaoEstadual, contato, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Pessoa Jur\u00C3\u00ADdica Altera uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> AlterarUsingPUT11AsyncWithHttpInfo (long? id, string razaoSocial, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT11");
            // verify the required parameter 'razaoSocial' is set
            if (razaoSocial == null) throw new ApiException(400, "Missing required parameter 'razaoSocial' when calling AlterarUsingPUT11");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
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
        public TelefoneEstabelecimentoResponse AlterarUsingPUT13 (long? id, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = AlterarUsingPUT13WithHttpInfo(id, ddd, telefone, ramal);
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
        public ApiResponse< TelefoneEstabelecimentoResponse > AlterarUsingPUT13WithHttpInfo (long? id, string ddd, string telefone, string ramal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT13");
            
            // verify the required parameter 'ddd' is set
            if (ddd == null)
                throw new ApiException(400, "Missing required parameter 'ddd' when calling EstabelecimentoApi->AlterarUsingPUT13");
            
            // verify the required parameter 'telefone' is set
            if (telefone == null)
                throw new ApiException(400, "Missing required parameter 'telefone' when calling EstabelecimentoApi->AlterarUsingPUT13");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> AlterarUsingPUT13Async (long? id, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await AlterarUsingPUT13AsyncWithHttpInfo(id, ddd, telefone, ramal);
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
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> AlterarUsingPUT13AsyncWithHttpInfo (long? id, string ddd, string telefone, string ramal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT13");
            // verify the required parameter 'ddd' is set
            if (ddd == null) throw new ApiException(400, "Missing required parameter 'ddd' when calling AlterarUsingPUT13");
            // verify the required parameter 'telefone' is set
            if (telefone == null) throw new ApiException(400, "Missing required parameter 'telefone' when calling AlterarUsingPUT13");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT13: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT13: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public TerminalResponse AlterarUsingPUT15 (long? id, TerminalUpdate terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = AlterarUsingPUT15WithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Altera um Terminal Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param> 
        /// <param name="terminalUpdate">terminalUpdate</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > AlterarUsingPUT15WithHttpInfo (long? id, TerminalUpdate terminalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT15");
            
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling EstabelecimentoApi->AlterarUsingPUT15");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TerminalResponse> AlterarUsingPUT15Async (long? id, TerminalUpdate terminalUpdate)
        {
             ApiResponse<TerminalResponse> localVarResponse = await AlterarUsingPUT15AsyncWithHttpInfo(id, terminalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Altera um Terminal Este m\u00C3\u00A9todo realiza a altera\u00C3\u00A7\u00C3\u00A3o dos Terminais.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do terminal (id).</param>
        /// <param name="terminalUpdate">terminalUpdate</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> AlterarUsingPUT15AsyncWithHttpInfo (long? id, TerminalUpdate terminalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT15");
            // verify the required parameter 'terminalUpdate' is set
            if (terminalUpdate == null) throw new ApiException(400, "Missing required parameter 'terminalUpdate' when calling AlterarUsingPUT15");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Alterar Credor Altera um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param> 
        /// <param name="credorUpdate">credorUpdate</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse AlterarUsingPUT5 (long? id, CredorDTO credorUpdate)
        {
             ApiResponse<CredorResponse> localVarResponse = AlterarUsingPUT5WithHttpInfo(id, credorUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Alterar Credor Altera um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param> 
        /// <param name="credorUpdate">credorUpdate</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > AlterarUsingPUT5WithHttpInfo (long? id, CredorDTO credorUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->AlterarUsingPUT5");
            
            // verify the required parameter 'credorUpdate' is set
            if (credorUpdate == null)
                throw new ApiException(400, "Missing required parameter 'credorUpdate' when calling EstabelecimentoApi->AlterarUsingPUT5");
            
    
            var localVarPath = "/api/credores/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (credorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// Alterar Credor Altera um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <param name="credorUpdate">credorUpdate</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> AlterarUsingPUT5Async (long? id, CredorDTO credorUpdate)
        {
             ApiResponse<CredorResponse> localVarResponse = await AlterarUsingPUT5AsyncWithHttpInfo(id, credorUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Alterar Credor Altera um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <param name="credorUpdate">credorUpdate</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> AlterarUsingPUT5AsyncWithHttpInfo (long? id, CredorDTO credorUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AlterarUsingPUT5");
            // verify the required parameter 'credorUpdate' is set
            if (credorUpdate == null) throw new ApiException(400, "Missing required parameter 'credorUpdate' when calling AlterarUsingPUT5");
            
    
            var localVarPath = "/api/credores/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (credorUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AlterarUsingPUT5: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar Credor Cadastra um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse CadastrarUsingPOST2 (CredorDTO credorPersist)
        {
             ApiResponse<CredorResponse> localVarResponse = CadastrarUsingPOST2WithHttpInfo(credorPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Credor Cadastra um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > CadastrarUsingPOST2WithHttpInfo (CredorDTO credorPersist)
        {
            
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null)
                throw new ApiException(400, "Missing required parameter 'credorPersist' when calling EstabelecimentoApi->CadastrarUsingPOST2");
            
    
            var localVarPath = "/api/credores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (credorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorPersist; // byte array
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
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar Credor Cadastra um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> CadastrarUsingPOST2Async (CredorDTO credorPersist)
        {
             ApiResponse<CredorResponse> localVarResponse = await CadastrarUsingPOST2AsyncWithHttpInfo(credorPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Credor Cadastra um credor.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="credorPersist">credorPersist</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> CadastrarUsingPOST2AsyncWithHttpInfo (CredorDTO credorPersist)
        {
            // verify the required parameter 'credorPersist' is set
            if (credorPersist == null) throw new ApiException(400, "Missing required parameter 'credorPersist' when calling CadastrarUsingPOST2");
            
    
            var localVarPath = "/api/credores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (credorPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(credorPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = credorPersist; // byte array
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

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param> 
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse CadastrarUsingPOST3 (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = CadastrarUsingPOST3WithHttpInfo(razaoSocial, cnpj, inscricaoEstadual, contato, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param> 
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > CadastrarUsingPOST3WithHttpInfo (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            
            // verify the required parameter 'razaoSocial' is set
            if (razaoSocial == null)
                throw new ApiException(400, "Missing required parameter 'razaoSocial' when calling EstabelecimentoApi->CadastrarUsingPOST3");
            
            // verify the required parameter 'cnpj' is set
            if (cnpj == null)
                throw new ApiException(400, "Missing required parameter 'cnpj' when calling EstabelecimentoApi->CadastrarUsingPOST3");
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> CadastrarUsingPOST3Async (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await CadastrarUsingPOST3AsyncWithHttpInfo(razaoSocial, cnpj, inscricaoEstadual, contato, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Cadastrar Pessoa Jur\u00C3\u00ADdica Cadastra uma pessoa jur\u00C3\u00ADdica.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> CadastrarUsingPOST3AsyncWithHttpInfo (string razaoSocial, string cnpj, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            // verify the required parameter 'razaoSocial' is set
            if (razaoSocial == null) throw new ApiException(400, "Missing required parameter 'razaoSocial' when calling CadastrarUsingPOST3");
            // verify the required parameter 'cnpj' is set
            if (cnpj == null) throw new ApiException(400, "Missing required parameter 'cnpj' when calling CadastrarUsingPOST3");
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (razaoSocial != null) localVarQueryParams.Add("razaoSocial", Configuration.ApiClient.ParameterToString(razaoSocial)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarUsingPOST3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// Consultar credor Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param> 
        /// <returns>CredorResponse</returns>
        public CredorResponse ConsultarUsingGET11 (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = ConsultarUsingGET11WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar credor Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param> 
        /// <returns>ApiResponse of CredorResponse</returns>
        public ApiResponse< CredorResponse > ConsultarUsingGET11WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET11");
            
    
            var localVarPath = "/api/credores/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }

        
        /// <summary>
        /// Consultar credor Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <returns>Task of CredorResponse</returns>
        public async System.Threading.Tasks.Task<CredorResponse> ConsultarUsingGET11Async (long? id)
        {
             ApiResponse<CredorResponse> localVarResponse = await ConsultarUsingGET11AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar credor Consulta um credor atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da credor</param>
        /// <returns>Task of ApiResponse (CredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CredorResponse>> ConsultarUsingGET11AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET11");
            
    
            var localVarPath = "/api/credores/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET11: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CredorResponse)));
            
        }
        
        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>EstabelecimentoResponse</returns>
        public EstabelecimentoResponse ConsultarUsingGET15 (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = ConsultarUsingGET15WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param> 
        /// <returns>ApiResponse of EstabelecimentoResponse</returns>
        public ApiResponse< EstabelecimentoResponse > ConsultarUsingGET15WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET15");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EstabelecimentoResponse> ConsultarUsingGET15Async (long? id)
        {
             ApiResponse<EstabelecimentoResponse> localVarResponse = await ConsultarUsingGET15AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar estabelecimento por id Consulta os detalhes de um determinado estabelecimento
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id</param>
        /// <returns>Task of ApiResponse (EstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EstabelecimentoResponse>> ConsultarUsingGET15AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET15");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET15: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param> 
        /// <returns>PessoaJuridicaResponse</returns>
        public PessoaJuridicaResponse ConsultarUsingGET20 (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = ConsultarUsingGET20WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param> 
        /// <returns>ApiResponse of PessoaJuridicaResponse</returns>
        public ApiResponse< PessoaJuridicaResponse > ConsultarUsingGET20WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET20");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
    
            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <returns>Task of PessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaResponse> ConsultarUsingGET20Async (long? id)
        {
             ApiResponse<PessoaJuridicaResponse> localVarResponse = await ConsultarUsingGET20AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Consultar pessoa jur\u00C3\u00ADdica Consulta uma pessoa jur\u00C3\u00ADdica atrav\u00C3\u00A9s do seu identificador.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o da pessoa jur\u00C3\u00ADdica</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaResponse>> ConsultarUsingGET20AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET20");
            
    
            var localVarPath = "/api/pessoas-juridicas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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

            return new ApiResponse<PessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaResponse)));
            
        }
        
        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param> 
        /// <returns>TelefoneEstabelecimentoResponse</returns>
        public TelefoneEstabelecimentoResponse ConsultarUsingGET26 (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = ConsultarUsingGET26WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param> 
        /// <returns>ApiResponse of TelefoneEstabelecimentoResponse</returns>
        public ApiResponse< TelefoneEstabelecimentoResponse > ConsultarUsingGET26WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET26");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> ConsultarUsingGET26Async (long? id)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await ConsultarUsingGET26AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado telefone de um estabelecimento Este m\u00C3\u00A9todo permite consultar um determinado telefone de um estabelecimento a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Telefone Estabelecimento (id).</param>
        /// <returns>Task of ApiResponse (TelefoneEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> ConsultarUsingGET26AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET26");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET26: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public TerminalResponse ConsultarUsingGET28 (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = ConsultarUsingGET28WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > ConsultarUsingGET28WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling EstabelecimentoApi->ConsultarUsingGET28");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TerminalResponse> ConsultarUsingGET28Async (long? id)
        {
             ApiResponse<TerminalResponse> localVarResponse = await ConsultarUsingGET28AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Apresenta os dados de um determinado Terminal Este m\u00C3\u00A9todo permite consultar um determinado Terminal a partir do seu c\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o (id).
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">C\u00C3\u00B3digo de Identifica\u00C3\u00A7\u00C3\u00A3o do Terminal (id).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> ConsultarUsingGET28AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ConsultarUsingGET28");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConsultarUsingGET28: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
        /// <summary>
        /// Listar credores Lista credores cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param> 
        /// <param name="nome">Nome do credor (optional)</param> 
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param> 
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param> 
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param> 
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param> 
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param> 
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param> 
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param> 
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param> 
        /// <param name="taxaBanco">Taxa do Banco (optional)</param> 
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param> 
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>PageCredorResponse</returns>
        public PageCredorResponse ListarUsingGET14 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PageCredorResponse> localVarResponse = ListarUsingGET14WithHttpInfo(sort, page, limit, idPessoaJuridica, nome, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, credorBanco, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar credores Lista credores cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param> 
        /// <param name="nome">Nome do credor (optional)</param> 
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param> 
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param> 
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param> 
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param> 
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param> 
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param> 
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param> 
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param> 
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param> 
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param> 
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param> 
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param> 
        /// <param name="taxaBanco">Taxa do Banco (optional)</param> 
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param> 
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>ApiResponse of PageCredorResponse</returns>
        public ApiResponse< PageCredorResponse > ListarUsingGET14WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            
    
            var localVarPath = "/api/credores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoaJuridica != null) localVarQueryParams.Add("idPessoaJuridica", Configuration.ApiClient.ParameterToString(idPessoaJuridica)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (credorBanco != null) localVarQueryParams.Add("credorBanco", Configuration.ApiClient.ParameterToString(credorBanco)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCredorResponse)));
            
        }

        
        /// <summary>
        /// Listar credores Lista credores cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param>
        /// <param name="nome">Nome do credor (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PageCredorResponse</returns>
        public async System.Threading.Tasks.Task<PageCredorResponse> ListarUsingGET14Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PageCredorResponse> localVarResponse = await ListarUsingGET14AsyncWithHttpInfo(sort, page, limit, idPessoaJuridica, nome, periodicidade, pagamentoSemanal, pagamentoMensal, pagamentoDecendialPrimeiro, pagamentoDecendialSegundo, pagamentoDecendialTerceiro, pagamentoQuinzenalPrimeiro, pagamentoQuinzenalSegundo, credorBanco, percentualRAV, recebeRAV, percentualMultiplica, taxaAdm, taxaBanco, limiteRAV, idCredorRAV, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar credores Lista credores cadastrados. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="idPessoaJuridica">Identificador da pessoa jur\u00C3\u00ADdica do credor (optional)</param>
        /// <param name="nome">Nome do credor (optional)</param>
        /// <param name="periodicidade">Periodicidade do pagamento (optional)</param>
        /// <param name="pagamentoSemanal">Dia para pagamento semanal (optional)</param>
        /// <param name="pagamentoMensal">Dia da data para o pagamento mensal (optional)</param>
        /// <param name="pagamentoDecendialPrimeiro">Dia da data para o primeiro pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialSegundo">Dia da data para o segundo pagamento decendial (optional)</param>
        /// <param name="pagamentoDecendialTerceiro">Dia da data para o terceiro pagamento decendial (optional)</param>
        /// <param name="pagamentoQuinzenalPrimeiro">Dia da data para o primeiro pagamento quinzenal (optional)</param>
        /// <param name="pagamentoQuinzenalSegundo">Dia da data para o segundo pagamento quinzenal (optional)</param>
        /// <param name="credorBanco">Indica se este credor pode ser um Credor RAV de outros credores (optional)</param>
        /// <param name="percentualRAV">Valor percentual do RAV do credor (optional)</param>
        /// <param name="recebeRAV">Indica se o credor recebe RAV e o tipo (optional)</param>
        /// <param name="percentualMultiplica">Percentual Multiplica (optional)</param>
        /// <param name="taxaAdm">Taxa Administrativa (optional)</param>
        /// <param name="taxaBanco">Taxa do Banco (optional)</param>
        /// <param name="limiteRAV">Valor limite do RAV (optional)</param>
        /// <param name="idCredorRAV">C\u00C3\u00B3digo identificador do credor RAV (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PageCredorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageCredorResponse>> ListarUsingGET14AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoaJuridica = null, string nome = null, string periodicidade = null, string pagamentoSemanal = null, int? pagamentoMensal = null, int? pagamentoDecendialPrimeiro = null, int? pagamentoDecendialSegundo = null, int? pagamentoDecendialTerceiro = null, int? pagamentoQuinzenalPrimeiro = null, int? pagamentoQuinzenalSegundo = null, bool? credorBanco = null, double? percentualRAV = null, string recebeRAV = null, double? percentualMultiplica = null, double? taxaAdm = null, double? taxaBanco = null, double? limiteRAV = null, long? idCredorRAV = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            
    
            var localVarPath = "/api/credores";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoaJuridica != null) localVarQueryParams.Add("idPessoaJuridica", Configuration.ApiClient.ParameterToString(idPessoaJuridica)); // query parameter
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (periodicidade != null) localVarQueryParams.Add("periodicidade", Configuration.ApiClient.ParameterToString(periodicidade)); // query parameter
            if (pagamentoSemanal != null) localVarQueryParams.Add("pagamentoSemanal", Configuration.ApiClient.ParameterToString(pagamentoSemanal)); // query parameter
            if (pagamentoMensal != null) localVarQueryParams.Add("pagamentoMensal", Configuration.ApiClient.ParameterToString(pagamentoMensal)); // query parameter
            if (pagamentoDecendialPrimeiro != null) localVarQueryParams.Add("pagamentoDecendialPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialPrimeiro)); // query parameter
            if (pagamentoDecendialSegundo != null) localVarQueryParams.Add("pagamentoDecendialSegundo", Configuration.ApiClient.ParameterToString(pagamentoDecendialSegundo)); // query parameter
            if (pagamentoDecendialTerceiro != null) localVarQueryParams.Add("pagamentoDecendialTerceiro", Configuration.ApiClient.ParameterToString(pagamentoDecendialTerceiro)); // query parameter
            if (pagamentoQuinzenalPrimeiro != null) localVarQueryParams.Add("pagamentoQuinzenalPrimeiro", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalPrimeiro)); // query parameter
            if (pagamentoQuinzenalSegundo != null) localVarQueryParams.Add("pagamentoQuinzenalSegundo", Configuration.ApiClient.ParameterToString(pagamentoQuinzenalSegundo)); // query parameter
            if (credorBanco != null) localVarQueryParams.Add("credorBanco", Configuration.ApiClient.ParameterToString(credorBanco)); // query parameter
            if (percentualRAV != null) localVarQueryParams.Add("percentualRAV", Configuration.ApiClient.ParameterToString(percentualRAV)); // query parameter
            if (recebeRAV != null) localVarQueryParams.Add("recebeRAV", Configuration.ApiClient.ParameterToString(recebeRAV)); // query parameter
            if (percentualMultiplica != null) localVarQueryParams.Add("percentualMultiplica", Configuration.ApiClient.ParameterToString(percentualMultiplica)); // query parameter
            if (taxaAdm != null) localVarQueryParams.Add("taxaAdm", Configuration.ApiClient.ParameterToString(taxaAdm)); // query parameter
            if (taxaBanco != null) localVarQueryParams.Add("taxaBanco", Configuration.ApiClient.ParameterToString(taxaBanco)); // query parameter
            if (limiteRAV != null) localVarQueryParams.Add("limiteRAV", Configuration.ApiClient.ParameterToString(limiteRAV)); // query parameter
            if (idCredorRAV != null) localVarQueryParams.Add("idCredorRAV", Configuration.ApiClient.ParameterToString(idCredorRAV)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET14: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageCredorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageCredorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageCredorResponse)));
            
        }
        
        /// <summary>
        /// Lista Estabelecimentos Lista todas os Estabelecimentos
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="id">C\u00C3\u00B3digo de identifica\u00C3\u00A7\u00C3\u00A3o do estabelecimento (id). (optional)</param> 
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
        /// <returns>PageEstabelecimentoResponse</returns>
        public PageEstabelecimentoResponse ListarUsingGET19 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = ListarUsingGET19WithHttpInfo(sort, page, limit, id, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo);
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
        /// <returns>ApiResponse of PageEstabelecimentoResponse</returns>
        public ApiResponse< PageEstabelecimentoResponse > ListarUsingGET19WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        /// <returns>Task of PageEstabelecimentoResponse</returns>
        public async System.Threading.Tasks.Task<PageEstabelecimentoResponse> ListarUsingGET19Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
        {
             ApiResponse<PageEstabelecimentoResponse> localVarResponse = await ListarUsingGET19AsyncWithHttpInfo(sort, page, limit, id, numeroReceitaFederal, nome, descricao, nomeFantasia, cep, nomeLogradouro, numeroEndereco, complemento, bairro, cidade, uf, pais, dataCadastramento, contato, email, flagArquivoSecrFazenda, flagCartaoDigitado, inativo);
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
        /// <returns>Task of ApiResponse (PageEstabelecimentoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEstabelecimentoResponse>> ListarUsingGET19AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? numeroReceitaFederal = null, string nome = null, string descricao = null, string nomeFantasia = null, string cep = null, string nomeLogradouro = null, long? numeroEndereco = null, string complemento = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataCadastramento = null, string contato = null, string email = null, int? flagArquivoSecrFazenda = null, int? flagCartaoDigitado = null, int? inativo = null)
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>PagePessoaJuridicaResponse</returns>
        public PagePessoaJuridicaResponse ListarUsingGET24 (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = ListarUsingGET24WithHttpInfo(sort, page, limit, razaoSocial, cnpj, inscricaoEstadual, contato, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param> 
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param> 
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param> 
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param> 
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param> 
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param> 
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param> 
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param> 
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param> 
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param> 
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param> 
        /// <returns>ApiResponse of PagePessoaJuridicaResponse</returns>
        public ApiResponse< PagePessoaJuridicaResponse > ListarUsingGET24WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
        }

        
        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of PagePessoaJuridicaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaJuridicaResponse> ListarUsingGET24Async (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
             ApiResponse<PagePessoaJuridicaResponse> localVarResponse = await ListarUsingGET24AsyncWithHttpInfo(sort, page, limit, razaoSocial, cnpj, inscricaoEstadual, contato, banco, agencia, digitoVerificadorAgencia, contaCorrente, digitoVerificadorContaCorrente);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar pessoas jur\u00C3\u00ADdicas Lista pessoas jur\u00C3\u00ADdicas cadastradas. 
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Tipo de ordena\u00C3\u00A7\u00C3\u00A3o dos registros. (optional)</param>
        /// <param name="page">P\u00C3\u00A1gina solicitada (Default = 0) (optional)</param>
        /// <param name="limit">Limite de elementos por solicita\u00C3\u00A7\u00C3\u00A3o (Default = 50, Max = 50) (optional)</param>
        /// <param name="razaoSocial">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="cnpj">C\u00C3\u00B3digo do Cadastro Nacional de Pessoas Jur\u00C3\u00ADdicas (optional)</param>
        /// <param name="inscricaoEstadual">N\u00C3\u00BAmero da inscri\u00C3\u00A7\u00C3\u00A3o estadual (optional)</param>
        /// <param name="contato">Nome da pessoa para entrar em contato (optional)</param>
        /// <param name="banco">C\u00C3\u00B3digo do banco (optional)</param>
        /// <param name="agencia">Raz\u00C3\u00A3o social da pessoa jur\u00C3\u00ADdica (optional)</param>
        /// <param name="digitoVerificadorAgencia">D\u00C3\u00ADgito Verificador da ag\u00C3\u00AAncia (optional)</param>
        /// <param name="contaCorrente">C\u00C3\u00B3digo da Conta Corrente (optional)</param>
        /// <param name="digitoVerificadorContaCorrente">D\u00C3\u00ADgito Verificador da Conta Corrente (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaJuridicaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaJuridicaResponse>> ListarUsingGET24AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, string razaoSocial = null, string cnpj = null, string inscricaoEstadual = null, string contato = null, int? banco = null, int? agencia = null, string digitoVerificadorAgencia = null, string contaCorrente = null, string digitoVerificadorContaCorrente = null)
        {
            
    
            var localVarPath = "/api/pessoas-juridicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (inscricaoEstadual != null) localVarQueryParams.Add("inscricaoEstadual", Configuration.ApiClient.ParameterToString(inscricaoEstadual)); // query parameter
            if (contato != null) localVarQueryParams.Add("contato", Configuration.ApiClient.ParameterToString(contato)); // query parameter
            if (banco != null) localVarQueryParams.Add("banco", Configuration.ApiClient.ParameterToString(banco)); // query parameter
            if (agencia != null) localVarQueryParams.Add("agencia", Configuration.ApiClient.ParameterToString(agencia)); // query parameter
            if (digitoVerificadorAgencia != null) localVarQueryParams.Add("digitoVerificadorAgencia", Configuration.ApiClient.ParameterToString(digitoVerificadorAgencia)); // query parameter
            if (contaCorrente != null) localVarQueryParams.Add("contaCorrente", Configuration.ApiClient.ParameterToString(contaCorrente)); // query parameter
            if (digitoVerificadorContaCorrente != null) localVarQueryParams.Add("digitoVerificadorContaCorrente", Configuration.ApiClient.ParameterToString(digitoVerificadorContaCorrente)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET24: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET24: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaJuridicaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaJuridicaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaJuridicaResponse)));
            
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
        public PageTelefoneEstabelecimentoResponse ListarUsingGET33 (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = ListarUsingGET33WithHttpInfo(sort, page, limit, idEstabelecimento);
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
        public ApiResponse< PageTelefoneEstabelecimentoResponse > ListarUsingGET33WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PageTelefoneEstabelecimentoResponse> ListarUsingGET33Async (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTelefoneEstabelecimentoResponse> localVarResponse = await ListarUsingGET33AsyncWithHttpInfo(sort, page, limit, idEstabelecimento);
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
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneEstabelecimentoResponse>> ListarUsingGET33AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idEstabelecimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET33: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public PageTerminalResponse ListarUsingGET35 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = ListarUsingGET35WithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
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
        public ApiResponse< PageTerminalResponse > ListarUsingGET35WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<PageTerminalResponse> ListarUsingGET35Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
        {
             ApiResponse<PageTerminalResponse> localVarResponse = await ListarUsingGET35AsyncWithHttpInfo(sort, page, limit, id, terminal, numeroEstabelecimento, idEstabelecimento);
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
        public async System.Threading.Tasks.Task<ApiResponse<PageTerminalResponse>> ListarUsingGET35AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string terminal = null, long? numeroEstabelecimento = null, long? idEstabelecimento = null)
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
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarUsingGET35: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTerminalResponse)));
            
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
        public TelefoneEstabelecimentoResponse SalvarUsingPOST19 (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = SalvarUsingPOST19WithHttpInfo(idEstabelecimento, ddd, telefone, ramal);
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
        public ApiResponse< TelefoneEstabelecimentoResponse > SalvarUsingPOST19WithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
            
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null)
                throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling EstabelecimentoApi->SalvarUsingPOST19");
            
            // verify the required parameter 'ddd' is set
            if (ddd == null)
                throw new ApiException(400, "Missing required parameter 'ddd' when calling EstabelecimentoApi->SalvarUsingPOST19");
            
            // verify the required parameter 'telefone' is set
            if (telefone == null)
                throw new ApiException(400, "Missing required parameter 'telefone' when calling EstabelecimentoApi->SalvarUsingPOST19");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<TelefoneEstabelecimentoResponse> SalvarUsingPOST19Async (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
             ApiResponse<TelefoneEstabelecimentoResponse> localVarResponse = await SalvarUsingPOST19AsyncWithHttpInfo(idEstabelecimento, ddd, telefone, ramal);
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
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneEstabelecimentoResponse>> SalvarUsingPOST19AsyncWithHttpInfo (long? idEstabelecimento, string ddd, string telefone, string ramal = null)
        {
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null) throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling SalvarUsingPOST19");
            // verify the required parameter 'ddd' is set
            if (ddd == null) throw new ApiException(400, "Missing required parameter 'ddd' when calling SalvarUsingPOST19");
            // verify the required parameter 'telefone' is set
            if (telefone == null) throw new ApiException(400, "Missing required parameter 'telefone' when calling SalvarUsingPOST19");
            
    
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
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST19: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST19: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneEstabelecimentoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneEstabelecimentoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneEstabelecimentoResponse)));
            
        }
        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param> 
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param> 
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param> 
        /// <returns>TerminalResponse</returns>
        public TerminalResponse SalvarUsingPOST21 (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual)
        {
             ApiResponse<TerminalResponse> localVarResponse = SalvarUsingPOST21WithHttpInfo(idEstabelecimento, flagConsultaExtrato, flagTerminalVirtual);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param> 
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param> 
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param> 
        /// <returns>ApiResponse of TerminalResponse</returns>
        public ApiResponse< TerminalResponse > SalvarUsingPOST21WithHttpInfo (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual)
        {
            
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null)
                throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling EstabelecimentoApi->SalvarUsingPOST21");
            
            // verify the required parameter 'flagConsultaExtrato' is set
            if (flagConsultaExtrato == null)
                throw new ApiException(400, "Missing required parameter 'flagConsultaExtrato' when calling EstabelecimentoApi->SalvarUsingPOST21");
            
            // verify the required parameter 'flagTerminalVirtual' is set
            if (flagTerminalVirtual == null)
                throw new ApiException(400, "Missing required parameter 'flagTerminalVirtual' when calling EstabelecimentoApi->SalvarUsingPOST21");
            
    
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
            
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (flagConsultaExtrato != null) localVarQueryParams.Add("flagConsultaExtrato", Configuration.ApiClient.ParameterToString(flagConsultaExtrato)); // query parameter
            if (flagTerminalVirtual != null) localVarQueryParams.Add("flagTerminalVirtual", Configuration.ApiClient.ParameterToString(flagTerminalVirtual)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }

        
        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param>
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <returns>Task of TerminalResponse</returns>
        public async System.Threading.Tasks.Task<TerminalResponse> SalvarUsingPOST21Async (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual)
        {
             ApiResponse<TerminalResponse> localVarResponse = await SalvarUsingPOST21AsyncWithHttpInfo(idEstabelecimento, flagConsultaExtrato, flagTerminalVirtual);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Realiza o cadastro de um novo Terminal Este m\u00C3\u00A9todo permite que seja cadastrado um novo Terminal.
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idEstabelecimento">Apresenta o id do estabelecimento.</param>
        /// <param name="flagConsultaExtrato">Flag indicando se o terminal \u00C3\u00A9 f\u00C3\u00ADsico ou virtual, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <param name="flagTerminalVirtual">Flag indicando se o terminal permite consultar extrato, sendo: (true: Sim), (false: N\u00C3\u00A3o)).</param>
        /// <returns>Task of ApiResponse (TerminalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TerminalResponse>> SalvarUsingPOST21AsyncWithHttpInfo (long? idEstabelecimento, bool? flagConsultaExtrato, bool? flagTerminalVirtual)
        {
            // verify the required parameter 'idEstabelecimento' is set
            if (idEstabelecimento == null) throw new ApiException(400, "Missing required parameter 'idEstabelecimento' when calling SalvarUsingPOST21");
            // verify the required parameter 'flagConsultaExtrato' is set
            if (flagConsultaExtrato == null) throw new ApiException(400, "Missing required parameter 'flagConsultaExtrato' when calling SalvarUsingPOST21");
            // verify the required parameter 'flagTerminalVirtual' is set
            if (flagTerminalVirtual == null) throw new ApiException(400, "Missing required parameter 'flagTerminalVirtual' when calling SalvarUsingPOST21");
            
    
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
            
            if (idEstabelecimento != null) localVarQueryParams.Add("idEstabelecimento", Configuration.ApiClient.ParameterToString(idEstabelecimento)); // query parameter
            if (flagConsultaExtrato != null) localVarQueryParams.Add("flagConsultaExtrato", Configuration.ApiClient.ParameterToString(flagConsultaExtrato)); // query parameter
            if (flagTerminalVirtual != null) localVarQueryParams.Add("flagTerminalVirtual", Configuration.ApiClient.ParameterToString(flagTerminalVirtual)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST21: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarUsingPOST21: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TerminalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TerminalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TerminalResponse)));
            
        }
        
    }
    
}
