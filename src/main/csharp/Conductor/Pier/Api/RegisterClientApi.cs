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
    public interface IRegisterClientApi
    {
        #region Synchronous Operations
        
        /// <summary>
        /// Update Aditional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be updated an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification code of the Person (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse Alterar (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
  
        /// <summary>
        /// Update Aditional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be updated an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification code of the Person (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> AlterarWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// Update the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse Alterar_0 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
  
        /// <summary>
        /// Update the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> Alterar_0WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Update the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be altered in the base of issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the account (optional)</param>
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse Alterar_1 (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);
  
        /// <summary>
        /// Update the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be altered in the base of issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the account (optional)</param>
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> Alterar_1WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);
        
        /// <summary>
        /// update the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be updated in the base of the issuer a register of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse Alterar_2 (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// update the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be updated in the base of the issuer a register of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> Alterar_2WithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Update a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a determined Telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="ddd">Phone DDD (optional)</param>
        /// <param name="telefone">Phone Number (optional)</param>
        /// <param name="ramal">Phone branch (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse Alterar_3 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Update a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a determined Telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="ddd">Phone DDD (optional)</param>
        /// <param name="telefone">Phone Number (optional)</param>
        /// <param name="ramal">Phone branch (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> Alterar_3WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Allow to attribute a document to an Account
        /// </summary>
        /// <remarks>
        /// this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param>
        /// <param name="body">Identification Code of the File</param>
        /// <returns>Object</returns>
        Object AtribuirAssinaturaCliente (long? id, AtribuirAssinaturaClientePersist body);
  
        /// <summary>
        /// Allow to attribute a document to an Account
        /// </summary>
        /// <remarks>
        /// this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param>
        /// <param name="body">Identification Code of the File</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> AtribuirAssinaturaClienteWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// Update integrated account with the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to update an integrated account with the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="body">Description of the input channel (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse Atualizar (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// Update integrated account with the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to update an integrated account with the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="body">Description of the input channel (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> AtualizarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Updates the mailing address to the typed address
        /// </summary>
        /// <remarks>
        /// This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <param name="idConta">Identification Code of the Count</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse AtualizarEnderecoDeCorrespondencia (long? id, long? idConta);
  
        /// <summary>
        /// Updates the mailing address to the typed address
        /// </summary>
        /// <remarks>
        /// This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <param name="idConta">Identification Code of the Count</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// Scheduled recharge registration
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new programmed recharge at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>CelularRecargaProgramadaResponse</returns>
        CelularRecargaProgramadaResponse Cadastrar (CelularRecargaProgramadaPersist persistencia);
  
        /// <summary>
        /// Scheduled recharge registration
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new programmed recharge at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        ApiResponse<CelularRecargaProgramadaResponse> CadastrarWithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// Make the Add-ons for an Account
        /// </summary>
        /// <remarks>
        /// This method allows an existing person in the base to be an additional account in the informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>AdicionalContaResponse</returns>
        AdicionalContaResponse CadastrarAdicional (long? id, AdicionalContaPersist adicionalContaPersist);
  
        /// <summary>
        /// Make the Add-ons for an Account
        /// </summary>
        /// <remarks>
        /// This method allows an existing person in the base to be an additional account in the informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        ApiResponse<AdicionalContaResponse> CadastrarAdicionalWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// Create the Register of Additional for an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be created an additional carrier for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse Cadastrar_0 (long? id, AdicionalPersist persist);
  
        /// <summary>
        /// Create the Register of Additional for an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be created an additional carrier for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> Cadastrar_0WithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// Creating additional account
        /// </summary>
        /// <remarks>
        /// This method allows to be  consulted an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>AdicionalDetalheResponse</returns>
        AdicionalDetalheResponse Consultar (long? id, long? idPessoa);
  
        /// <summary>
        /// Creating additional account
        /// </summary>
        /// <remarks>
        /// This method allows to be  consulted an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        ApiResponse<AdicionalDetalheResponse> ConsultarWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Show the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve a determined address using the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse Consultar_0 (long? id);
  
        /// <summary>
        /// Show the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve a determined address using the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> Consultar_0WithHttpInfo (long? id);
        
        /// <summary>
        /// List the details of a determined person
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse Consultar_1 (long? id);
  
        /// <summary>
        /// List the details of a determined person
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> Consultar_1WithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse Consultar_2 (long? id);
  
        /// <summary>
        /// List the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> Consultar_2WithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined telephone using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse Consultar_3 (long? id);
  
        /// <summary>
        /// List the dates of a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined telephone using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> Consultar_3WithHttpInfo (long? id);
        
        /// <summary>
        /// Inactive Additional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows tobe inactived an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>string</returns>
        string Inativar (long? id, long? idPessoa);
  
        /// <summary>
        /// Inactive Additional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows tobe inactived an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> InativarWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// List the additionals of an account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed additional carriers of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>AdicionalResponse</returns>
        AdicionalResponse Listar (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the additionals of an account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed additional carriers of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of AdicionalResponse</returns>
        ApiResponse<AdicionalResponse> ListarWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the account of the person
        /// </summary>
        /// <remarks>
        /// Allow to list the accounts of a person using the number at the IRs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PageContaDetalheResponse</returns>
        PageContaDetalheResponse ListarContasPorPessoa (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List the account of the person
        /// </summary>
        /// <remarks>
        /// Allow to list the accounts of a person using the number at the IRs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        ApiResponse<PageContaDetalheResponse> ListarContasPorPessoaWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the updates of telephones made in the last 60 days
        /// </summary>
        /// <remarks>
        /// This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param>
        /// <returns>HistoricoTelefoneResponse</returns>
        HistoricoTelefoneResponse ListarHistoricoTelefones (long? id);
  
        /// <summary>
        /// List the updates of telephones made in the last 60 days
        /// </summary>
        /// <remarks>
        /// This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param>
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        ApiResponse<HistoricoTelefoneResponse> ListarHistoricoTelefonesWithHttpInfo (long? id);
        
        /// <summary>
        /// List partners of a legal entity
        /// </summary>
        /// <remarks>
        /// Lista the partners linked to a legal entity registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse ListarSocios (long? id, List<string> sort = null, int? page = null, int? limit = null);
  
        /// <summary>
        /// List partners of a legal entity
        /// </summary>
        /// <remarks>
        /// Lista the partners linked to a legal entity registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> ListarSociosWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the addresses created by the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the addresses in the datababse of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Address (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param>
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param>
        /// <param name="logradouro">List the name of the Street (optional)</param>
        /// <param name="numero">List the number of address (optional)</param>
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param>
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param>
        /// <param name="bairro">List the name of the neighborhood (optional)</param>
        /// <param name="cidade">List the name of the city (optional)</param>
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param>
        /// <param name="pais">List the name of the Country (optional)</param>
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param>
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <returns>PageEnderecoResponse</returns>
        PageEnderecoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
  
        /// <summary>
        /// List the addresses created by the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the addresses in the datababse of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Address (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param>
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param>
        /// <param name="logradouro">List the name of the Street (optional)</param>
        /// <param name="numero">List the number of address (optional)</param>
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param>
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param>
        /// <param name="bairro">List the name of the neighborhood (optional)</param>
        /// <param name="cidade">List the name of the city (optional)</param>
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param>
        /// <param name="pais">List the name of the Country (optional)</param>
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param>
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        ApiResponse<PageEnderecoResponse> Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// List the People registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Person (id) (optional)</param>
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param>
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param>
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param>
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param>
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param>
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param>
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param>
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param>
        /// <returns>PagePessoaResponse</returns>
        PagePessoaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// List the People registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Person (id) (optional)</param>
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param>
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param>
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param>
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param>
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param>
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param>
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param>
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param>
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        ApiResponse<PagePessoaResponse> Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// List the details of the people registered in the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the details of the people existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">Identifier Code of the person (optional)</param>
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the Bank (optional)</param>
        /// <param name="numeroAgencia">Number of the Agency (optional)</param>
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>PagePessoaDetalheResponse</returns>
        PagePessoaDetalheResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
  
        /// <summary>
        /// List the details of the people registered in the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the details of the people existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">Identifier Code of the person (optional)</param>
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the Bank (optional)</param>
        /// <param name="numeroAgencia">Number of the Agency (optional)</param>
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        ApiResponse<PagePessoaDetalheResponse> Listar_2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// List the Telephones registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param>
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">Telephone DDD (id) (optional)</param>
        /// <param name="telefone">Telephone number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param>
        /// <returns>PageTelefoneResponse</returns>
        PageTelefoneResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
  
        /// <summary>
        /// List the Telephones registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param>
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">Telephone DDD (id) (optional)</param>
        /// <param name="telefone">Telephone number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param>
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        ApiResponse<PageTelefoneResponse> Listar_3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Include an account as a register for integration
        /// </summary>
        /// <remarks>
        /// This resource allows to include an account as a register for integration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>IntegracaoEmissorResponse</returns>
        IntegracaoEmissorResponse Salvar (long? id, IntegracaoEmissorPersist body = null);
  
        /// <summary>
        /// Include an account as a register for integration
        /// </summary>
        /// <remarks>
        /// This resource allows to include an account as a register for integration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        ApiResponse<IntegracaoEmissorResponse> SalvarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ObjectApprovedIndividual</returns>
        ObjectApprovedIndividual SalvarPessoaFisicaAprovada (ObjectApprovedIndividual pessoaPersist);
  
        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of ObjectApprovedIndividual</returns>
        ApiResponse<ObjectApprovedIndividual> SalvarPessoaFisicaAprovadaWithHttpInfo (ObjectApprovedIndividual pessoaPersist);
        
        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovada (PessoaJuridicaAprovadaPersist pessoaPersist);
  
        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        ApiResponse<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Includes integration record
        /// </summary>
        /// <remarks>
        /// This feature allows you to include an integration record
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManager (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
  
        /// <summary>
        /// Includes integration record
        /// </summary>
        /// <remarks>
        /// This feature allows you to include an integration record
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        ApiResponse<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// Create a register of a new Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new Address in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>EnderecoResponse</returns>
        EnderecoResponse Salvar_0 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
  
        /// <summary>
        /// Create a register of a new Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new Address in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>ApiResponse of EnderecoResponse</returns>
        ApiResponse<EnderecoResponse> Salvar_0WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Create the register of a new Person
        /// </summary>
        /// <remarks>
        /// this method allows to be registered a new Person in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>PessoaResponse</returns>
        PessoaResponse Salvar_1 (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
  
        /// <summary>
        /// Create the register of a new Person
        /// </summary>
        /// <remarks>
        /// this method allows to be registered a new Person in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>ApiResponse of PessoaResponse</returns>
        ApiResponse<PessoaResponse> Salvar_1WithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Save the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be included in the base of the issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param>
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param>
        /// <param name="idProfissao">Physical person occupation (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>PessoaDetalheResponse</returns>
        PessoaDetalheResponse Salvar_2 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
  
        /// <summary>
        /// Save the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be included in the base of the issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param>
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param>
        /// <param name="idProfissao">Physical person occupation (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        ApiResponse<PessoaDetalheResponse> Salvar_2WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// Create a register of a new Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param>
        /// <param name="telefone">Telephone Number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <returns>TelefoneResponse</returns>
        TelefoneResponse Salvar_3 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
  
        /// <summary>
        /// Create a register of a new Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param>
        /// <param name="telefone">Telephone Number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <returns>ApiResponse of TelefoneResponse</returns>
        ApiResponse<TelefoneResponse> Salvar_3WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Synchronous Operations
        
        #region Asynchronous Operations
        
        /// <summary>
        /// Update Aditional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be updated an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification code of the Person (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);

        /// <summary>
        /// Update Aditional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be updated an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification code of the Person (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate);
        
        /// <summary>
        /// Update the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> Alterar_0Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);

        /// <summary>
        /// Update the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Alterar_0AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Update the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be altered in the base of issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the account (optional)</param>
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> Alterar_1Async (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);

        /// <summary>
        /// Update the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be altered in the base of issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the account (optional)</param>
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Alterar_1AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null);
        
        /// <summary>
        /// update the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be updated in the base of the issuer a register of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> Alterar_2Async (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// update the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be updated in the base of the issuer a register of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Alterar_2AsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Update a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a determined Telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="ddd">Phone DDD (optional)</param>
        /// <param name="telefone">Phone Number (optional)</param>
        /// <param name="ramal">Phone branch (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> Alterar_3Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Update a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be updated a determined Telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="ddd">Phone DDD (optional)</param>
        /// <param name="telefone">Phone Number (optional)</param>
        /// <param name="ramal">Phone branch (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Alterar_3AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null);
        
        /// <summary>
        /// Allow to attribute a document to an Account
        /// </summary>
        /// <remarks>
        /// this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param>
        /// <param name="body">Identification Code of the File</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteAsync (long? id, AtribuirAssinaturaClientePersist body);

        /// <summary>
        /// Allow to attribute a document to an Account
        /// </summary>
        /// <remarks>
        /// this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param>
        /// <param name="body">Identification Code of the File</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body);
        
        /// <summary>
        /// Update integrated account with the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to update an integrated account with the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="body">Description of the input channel (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarAsync (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// Update integrated account with the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to update an integrated account with the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="body">Description of the input channel (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Updates the mailing address to the typed address
        /// </summary>
        /// <remarks>
        /// This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <param name="idConta">Identification Code of the Count</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaAsync (long? id, long? idConta);

        /// <summary>
        /// Updates the mailing address to the typed address
        /// </summary>
        /// <remarks>
        /// This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <param name="idConta">Identification Code of the Count</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtualizarEnderecoDeCorrespondenciaAsyncWithHttpInfo (long? id, long? idConta);
        
        /// <summary>
        /// Scheduled recharge registration
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new programmed recharge at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarAsync (CelularRecargaProgramadaPersist persistencia);

        /// <summary>
        /// Scheduled recharge registration
        /// </summary>
        /// <remarks>
        /// This feature allows you to register a new programmed recharge at the sender base
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarAsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia);
        
        /// <summary>
        /// Make the Add-ons for an Account
        /// </summary>
        /// <remarks>
        /// This method allows an existing person in the base to be an additional account in the informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        System.Threading.Tasks.Task<AdicionalContaResponse> CadastrarAdicionalAsync (long? id, AdicionalContaPersist adicionalContaPersist);

        /// <summary>
        /// Make the Add-ons for an Account
        /// </summary>
        /// <remarks>
        /// This method allows an existing person in the base to be an additional account in the informed
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> CadastrarAdicionalAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist);
        
        /// <summary>
        /// Create the Register of Additional for an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be created an additional carrier for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> Cadastrar_0Async (long? id, AdicionalPersist persist);

        /// <summary>
        /// Create the Register of Additional for an Account
        /// </summary>
        /// <remarks>
        /// This method allows to be created an additional carrier for a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> Cadastrar_0AsyncWithHttpInfo (long? id, AdicionalPersist persist);
        
        /// <summary>
        /// Creating additional account
        /// </summary>
        /// <remarks>
        /// This method allows to be  consulted an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarAsync (long? id, long? idPessoa);

        /// <summary>
        /// Creating additional account
        /// </summary>
        /// <remarks>
        /// This method allows to be  consulted an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// Show the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve a determined address using the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> Consultar_0Async (long? id);

        /// <summary>
        /// Show the dates of a determined Address
        /// </summary>
        /// <remarks>
        /// This resource allows to retrieve a determined address using the id code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Consultar_0AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the details of a determined person
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> Consultar_1Async (long? id);

        /// <summary>
        /// List the details of a determined person
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> Consultar_2Async (long? id);

        /// <summary>
        /// List the dates of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Consultar_2AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List the dates of a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined telephone using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> Consultar_3Async (long? id);

        /// <summary>
        /// List the dates of a determined Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to retrieve a determined telephone using its identification code (id)
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Consultar_3AsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// Inactive Additional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows tobe inactived an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> InativarAsync (long? id, long? idPessoa);

        /// <summary>
        /// Inactive Additional of an Account
        /// </summary>
        /// <remarks>
        /// This method allows tobe inactived an additional carrier of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> InativarAsyncWithHttpInfo (long? id, long? idPessoa);
        
        /// <summary>
        /// List the additionals of an account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed additional carriers of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        System.Threading.Tasks.Task<AdicionalResponse> ListarAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the additionals of an account
        /// </summary>
        /// <remarks>
        /// This method allows to be listed additional carriers of a determined account
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the account of the person
        /// </summary>
        /// <remarks>
        /// Allow to list the accounts of a person using the number at the IRs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List the account of the person
        /// </summary>
        /// <remarks>
        /// Allow to list the accounts of a person using the number at the IRs
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the updates of telephones made in the last 60 days
        /// </summary>
        /// <remarks>
        /// This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesAsync (long? id);

        /// <summary>
        /// List the updates of telephones made in the last 60 days
        /// </summary>
        /// <remarks>
        /// This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// List partners of a legal entity
        /// </summary>
        /// <remarks>
        /// Lista the partners linked to a legal entity registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosAsync (long? id, List<string> sort = null, int? page = null, int? limit = null);

        /// <summary>
        /// List partners of a legal entity
        /// </summary>
        /// <remarks>
        /// Lista the partners linked to a legal entity registered
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null);
        
        /// <summary>
        /// List the addresses created by the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the addresses in the datababse of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Address (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param>
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param>
        /// <param name="logradouro">List the name of the Street (optional)</param>
        /// <param name="numero">List the number of address (optional)</param>
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param>
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param>
        /// <param name="bairro">List the name of the neighborhood (optional)</param>
        /// <param name="cidade">List the name of the city (optional)</param>
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param>
        /// <param name="pais">List the name of the Country (optional)</param>
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param>
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        System.Threading.Tasks.Task<PageEnderecoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);

        /// <summary>
        /// List the addresses created by the Issuer
        /// </summary>
        /// <remarks>
        /// This resource allows to be listed the addresses in the datababse of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Address (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param>
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param>
        /// <param name="logradouro">List the name of the Street (optional)</param>
        /// <param name="numero">List the number of address (optional)</param>
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param>
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param>
        /// <param name="bairro">List the name of the neighborhood (optional)</param>
        /// <param name="cidade">List the name of the city (optional)</param>
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param>
        /// <param name="pais">List the name of the Country (optional)</param>
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param>
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null);
        
        /// <summary>
        /// List the People registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Person (id) (optional)</param>
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param>
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param>
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param>
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param>
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param>
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param>
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param>
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        System.Threading.Tasks.Task<PagePessoaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// List the People registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the People existent in the database of issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Person (id) (optional)</param>
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param>
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param>
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param>
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param>
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param>
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param>
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param>
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// List the details of the people registered in the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the details of the people existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">Identifier Code of the person (optional)</param>
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the Bank (optional)</param>
        /// <param name="numeroAgencia">Number of the Agency (optional)</param>
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PagePessoaDetalheResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);

        /// <summary>
        /// List the details of the people registered in the issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the details of the people existent in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">Identifier Code of the person (optional)</param>
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the Bank (optional)</param>
        /// <param name="numeroAgencia">Number of the Agency (optional)</param>
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> Listar_2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// List the Telephones registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param>
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">Telephone DDD (id) (optional)</param>
        /// <param name="telefone">Telephone number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        System.Threading.Tasks.Task<PageTelefoneResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);

        /// <summary>
        /// List the Telephones registered in the Issuer
        /// </summary>
        /// <remarks>
        /// This method allows to be listed the telephones in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param>
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">Telephone DDD (id) (optional)</param>
        /// <param name="telefone">Telephone number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> Listar_3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null);
        
        /// <summary>
        /// Include an account as a register for integration
        /// </summary>
        /// <remarks>
        /// This resource allows to include an account as a register for integration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarAsync (long? id, IntegracaoEmissorPersist body = null);

        /// <summary>
        /// Include an account as a register for integration
        /// </summary>
        /// <remarks>
        /// This resource allows to include an account as a register for integration
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null);
        
        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ObjectApprovedIndividual</returns>
        System.Threading.Tasks.Task<ObjectApprovedIndividual> SalvarPessoaFisicaAprovadaAsync (ObjectApprovedIndividual pessoaPersist);

        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (ObjectApprovedIndividual)</returns>
        System.Threading.Tasks.Task<ApiResponse<ObjectApprovedIndividual>> SalvarPessoaFisicaAprovadaAsyncWithHttpInfo (ObjectApprovedIndividual pessoaPersist);
        
        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaAsync (PessoaJuridicaAprovadaPersist pessoaPersist);

        /// <summary>
        /// Create the Account and Legal Entity
        /// </summary>
        /// <remarks>
        /// Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist);
        
        /// <summary>
        /// Includes integration record
        /// </summary>
        /// <remarks>
        /// This feature allows you to include an integration record
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);

        /// <summary>
        /// Includes integration record
        /// </summary>
        /// <remarks>
        /// This feature allows you to include an integration record
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist);
        
        /// <summary>
        /// Create a register of a new Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new Address in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        System.Threading.Tasks.Task<EnderecoResponse> Salvar_0Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);

        /// <summary>
        /// Create a register of a new Address
        /// </summary>
        /// <remarks>
        /// This resource allows to be created a new Address in the database of the Issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Salvar_0AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null);
        
        /// <summary>
        /// Create the register of a new Person
        /// </summary>
        /// <remarks>
        /// this method allows to be registered a new Person in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        System.Threading.Tasks.Task<PessoaResponse> Salvar_1Async (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);

        /// <summary>
        /// Create the register of a new Person
        /// </summary>
        /// <remarks>
        /// this method allows to be registered a new Person in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Salvar_1AsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null);
        
        /// <summary>
        /// Save the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be included in the base of the issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param>
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param>
        /// <param name="idProfissao">Physical person occupation (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        System.Threading.Tasks.Task<PessoaDetalheResponse> Salvar_2Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);

        /// <summary>
        /// Save the details of a determined Person
        /// </summary>
        /// <remarks>
        /// This method allows to be included in the base of the issuer the details of a determined Person
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param>
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param>
        /// <param name="idProfissao">Physical person occupation (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Salvar_2AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null);
        
        /// <summary>
        /// Create a register of a new Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param>
        /// <param name="telefone">Telephone Number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        System.Threading.Tasks.Task<TelefoneResponse> Salvar_3Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);

        /// <summary>
        /// Create a register of a new Telephone
        /// </summary>
        /// <remarks>
        /// This method allows to be created a new telephone in the database of the issuer
        /// </remarks>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param>
        /// <param name="telefone">Telephone Number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Salvar_3AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null);
        
        #endregion Asynchronous Operations
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RegisterClientApi : IRegisterClientApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RegisterClientApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterClientApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RegisterClientApi(Configuration configuration = null)
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
        /// Update Aditional of an Account This method allows to be updated an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idPessoa">Identification code of the Person (id)</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse Alterar (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = AlterarWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Aditional of an Account This method allows to be updated an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="idPessoa">Identification code of the Person (id)</param> 
        /// <param name="adicionalUpdate">adicionalUpdate</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > AlterarWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Alterar");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling RegisterClientApi->Alterar");
            
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null)
                throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling RegisterClientApi->Alterar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (adicionalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalUpdate; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Update Aditional of an Account This method allows to be updated an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification code of the Person (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> AlterarAsync (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await AlterarAsyncWithHttpInfo(id, idPessoa, adicionalUpdate);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Aditional of an Account This method allows to be updated an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="idPessoa">Identification code of the Person (id)</param>
        /// <param name="adicionalUpdate">adicionalUpdate</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> AlterarAsyncWithHttpInfo (long? id, long? idPessoa, AdicionalUpdate adicionalUpdate)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Alterar");
            // verify the required parameter 'adicionalUpdate' is set
            if (adicionalUpdate == null) throw new ApiException(400, "Missing required parameter 'adicionalUpdate' when calling Alterar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            if (adicionalUpdate.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalUpdate); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalUpdate; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Update the dates of a determined Address This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param> 
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param> 
        /// <param name="cep">CEP (optional)</param> 
        /// <param name="logradouro">Show the Street name (optional)</param> 
        /// <param name="numero">Show the number of the address (optional)</param> 
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param> 
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param> 
        /// <param name="bairro">Show the name of the neighborhood (optional)</param> 
        /// <param name="cidade">Show the name of the city (optional)</param> 
        /// <param name="uf">Show Federal Unity Acronym (optional)</param> 
        /// <param name="pais">Show the name of the Country (optional)</param> 
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param> 
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param> 
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse Alterar_0 (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = Alterar_0WithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the dates of a determined Address This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param> 
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param> 
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param> 
        /// <param name="cep">CEP (optional)</param> 
        /// <param name="logradouro">Show the Street name (optional)</param> 
        /// <param name="numero">Show the number of the address (optional)</param> 
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param> 
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param> 
        /// <param name="bairro">Show the name of the neighborhood (optional)</param> 
        /// <param name="cidade">Show the name of the city (optional)</param> 
        /// <param name="uf">Show Federal Unity Acronym (optional)</param> 
        /// <param name="pais">Show the name of the Country (optional)</param> 
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param> 
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param> 
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > Alterar_0WithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Alterar_0");
            
    
            var localVarPath = "/api/enderecos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Update the dates of a determined Address This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> Alterar_0Async (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await Alterar_0AsyncWithHttpInfo(id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the dates of a determined Address This resource allows to be updated in the base of the Issuer one or more registers linked to a dtermined Address
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">id</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Alterar_0AsyncWithHttpInfo (long? id, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_0");
            
    
            var localVarPath = "/api/enderecos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Update the details of a determined Person This method allows to be altered in the base of issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param> 
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param> 
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param> 
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param> 
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param> 
        /// <param name="numeroBanco">Number of the account (optional)</param> 
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param> 
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param> 
        /// <param name="email">Email of the physical person (optional)</param> 
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param> 
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param> 
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param> 
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param> 
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param> 
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param> 
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param> 
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param> 
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse Alterar_1 (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = Alterar_1WithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the details of a determined Person This method allows to be altered in the base of issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param> 
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param> 
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param> 
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param> 
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param> 
        /// <param name="numeroBanco">Number of the account (optional)</param> 
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param> 
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param> 
        /// <param name="email">Email of the physical person (optional)</param> 
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param> 
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param> 
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param> 
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param> 
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param> 
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param> 
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param> 
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param> 
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > Alterar_1WithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Alterar_1");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Update the details of a determined Person This method allows to be altered in the base of issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the account (optional)</param>
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> Alterar_1Async (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await Alterar_1AsyncWithHttpInfo(id, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, impedidoFinanciamento, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the details of a determined Person This method allows to be altered in the base of issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <param name="nomeMae">Show the mothe name of the physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical Person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Nature Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the account (optional)</param>
        /// <param name="numeroAgencia">Numbe of the angency (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that should be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Alterar_1AsyncWithHttpInfo (long? id, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, bool? impedidoFinanciamento = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_1");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// update the dates of a determined Person This method allows to be updated in the base of the issuer a register of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param> 
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param> 
        /// <param name="tipo">Kind of Person (PF or PJ)</param> 
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param> 
        /// <param name="cpf">CPF number, when it is PF (optional)</param> 
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param> 
        /// <param name="sexo">Person Gender (optional)</param> 
        /// <param name="numeroIdentidade">Identity Number (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse Alterar_2 (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = Alterar_2WithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// update the dates of a determined Person This method allows to be updated in the base of the issuer a register of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param> 
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param> 
        /// <param name="tipo">Kind of Person (PF or PJ)</param> 
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param> 
        /// <param name="cpf">CPF number, when it is PF (optional)</param> 
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param> 
        /// <param name="sexo">Person Gender (optional)</param> 
        /// <param name="numeroIdentidade">Identity Number (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > Alterar_2WithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Alterar_2");
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling RegisterClientApi->Alterar_2");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling RegisterClientApi->Alterar_2");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling RegisterClientApi->Alterar_2");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// update the dates of a determined Person This method allows to be updated in the base of the issuer a register of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> Alterar_2Async (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await Alterar_2AsyncWithHttpInfo(id, nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// update the dates of a determined Person This method allows to be updated in the base of the issuer a register of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the person</param>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Alterar_2AsyncWithHttpInfo (long? id, string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_2");
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling Alterar_2");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling Alterar_2");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling Alterar_2");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Update a determined Telephone This method allows to be updated a determined Telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param> 
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param> 
        /// <param name="ddd">Phone DDD (optional)</param> 
        /// <param name="telefone">Phone Number (optional)</param> 
        /// <param name="ramal">Phone branch (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse Alterar_3 (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = Alterar_3WithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a determined Telephone This method allows to be updated a determined Telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param> 
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param> 
        /// <param name="ddd">Phone DDD (optional)</param> 
        /// <param name="telefone">Phone Number (optional)</param> 
        /// <param name="ramal">Phone branch (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > Alterar_3WithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Alterar_3");
            
    
            var localVarPath = "/api/telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Update a determined Telephone This method allows to be updated a determined Telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="ddd">Phone DDD (optional)</param>
        /// <param name="telefone">Phone Number (optional)</param>
        /// <param name="ramal">Phone branch (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> Alterar_3Async (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await Alterar_3AsyncWithHttpInfo(id, idTipoTelefone, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a determined Telephone This method allows to be updated a determined Telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the telephone (id)</param>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="ddd">Phone DDD (optional)</param>
        /// <param name="telefone">Phone Number (optional)</param>
        /// <param name="ramal">Phone branch (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Alterar_3AsyncWithHttpInfo (long? id, long? idTipoTelefone = null, string ddd = null, string telefone = null, string ramal = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Alterar_3");
            
    
            var localVarPath = "/api/telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Alterar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Allow to attribute a document to an Account this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param> 
        /// <param name="body">Identification Code of the File</param> 
        /// <returns>Object</returns>
        public Object AtribuirAssinaturaCliente (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = AtribuirAssinaturaClienteWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Allow to attribute a document to an Account this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param> 
        /// <param name="body">Identification Code of the File</param> 
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > AtribuirAssinaturaClienteWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->AtribuirAssinaturaCliente");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RegisterClientApi->AtribuirAssinaturaCliente");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-assinatura-cliente";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }

        
        /// <summary>
        /// Allow to attribute a document to an Account this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param>
        /// <param name="body">Identification Code of the File</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> AtribuirAssinaturaClienteAsync (long? id, AtribuirAssinaturaClientePersist body)
        {
             ApiResponse<Object> localVarResponse = await AtribuirAssinaturaClienteAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Allow to attribute a document to an Account this method allows to be attributed to a determined account a document that is storaged on the PIER Cloud, informing what is the type of the document and its respective Id
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account</param>
        /// <param name="body">Identification Code of the File</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> AtribuirAssinaturaClienteAsyncWithHttpInfo (long? id, AtribuirAssinaturaClientePersist body)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtribuirAssinaturaCliente");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling AtribuirAssinaturaCliente");
            
    
            var localVarPath = "/api/contas/{id}/atribuir-assinatura-cliente";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtribuirAssinaturaCliente: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
            
        }
        
        /// <summary>
        /// Update integrated account with the Issuer This resource allows to update an integrated account with the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="body">Description of the input channel (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse Atualizar (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = AtualizarWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update integrated account with the Issuer This resource allows to update an integrated account with the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="body">Description of the input channel (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > AtualizarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Atualizar");
            
    
            var localVarPath = "/api/contas/{id}/atualizar-registro-integracao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// Update integrated account with the Issuer This resource allows to update an integrated account with the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="body">Description of the input channel (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> AtualizarAsync (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await AtualizarAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update integrated account with the Issuer This resource allows to update an integrated account with the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="body">Description of the input channel (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> AtualizarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Atualizar");
            
    
            var localVarPath = "/api/contas/{id}/atualizar-registro-integracao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Atualizar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// Updates the mailing address to the typed address This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param> 
        /// <param name="idConta">Identification Code of the Count</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse AtualizarEnderecoDeCorrespondencia (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = AtualizarEnderecoDeCorrespondenciaWithHttpInfo(id, idConta);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates the mailing address to the typed address This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param> 
        /// <param name="idConta">Identification Code of the Count</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > AtualizarEnderecoDeCorrespondenciaWithHttpInfo (long? id, long? idConta)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->AtualizarEnderecoDeCorrespondencia");
            
            // verify the required parameter 'idConta' is set
            if (idConta == null)
                throw new ApiException(400, "Missing required parameter 'idConta' when calling RegisterClientApi->AtualizarEnderecoDeCorrespondencia");
            
    
            var localVarPath = "/api/enderecos/{id}/alterar-endereco-correspondencia";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Updates the mailing address to the typed address This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <param name="idConta">Identification Code of the Count</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> AtualizarEnderecoDeCorrespondenciaAsync (long? id, long? idConta)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await AtualizarEnderecoDeCorrespondenciaAsyncWithHttpInfo(id, idConta);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates the mailing address to the typed address This method allows the mailing address of a given account to be updated to the mailing address informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <param name="idConta">Identification Code of the Count</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> AtualizarEnderecoDeCorrespondenciaAsyncWithHttpInfo (long? id, long? idConta)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AtualizarEnderecoDeCorrespondencia");
            // verify the required parameter 'idConta' is set
            if (idConta == null) throw new ApiException(400, "Missing required parameter 'idConta' when calling AtualizarEnderecoDeCorrespondencia");
            
    
            var localVarPath = "/api/enderecos/{id}/alterar-endereco-correspondencia";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            if (idConta != null) localVarQueryParams.Add("idConta", Configuration.ApiClient.ParameterToString(idConta)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling AtualizarEnderecoDeCorrespondencia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Scheduled recharge registration This feature allows you to register a new programmed recharge at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>CelularRecargaProgramadaResponse</returns>
        public CelularRecargaProgramadaResponse Cadastrar (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = CadastrarWithHttpInfo(persistencia);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Scheduled recharge registration This feature allows you to register a new programmed recharge at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param> 
        /// <returns>ApiResponse of CelularRecargaProgramadaResponse</returns>
        public ApiResponse< CelularRecargaProgramadaResponse > CadastrarWithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            
            // verify the required parameter 'persistencia' is set
            if (persistencia == null)
                throw new ApiException(400, "Missing required parameter 'persistencia' when calling RegisterClientApi->Cadastrar");
            
    
            var localVarPath = "/api/celulares/recargas-programadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (persistencia.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistencia); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistencia; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }

        
        /// <summary>
        /// Scheduled recharge registration This feature allows you to register a new programmed recharge at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of CelularRecargaProgramadaResponse</returns>
        public async System.Threading.Tasks.Task<CelularRecargaProgramadaResponse> CadastrarAsync (CelularRecargaProgramadaPersist persistencia)
        {
             ApiResponse<CelularRecargaProgramadaResponse> localVarResponse = await CadastrarAsyncWithHttpInfo(persistencia);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Scheduled recharge registration This feature allows you to register a new programmed recharge at the sender base
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="persistencia">persistencia</param>
        /// <returns>Task of ApiResponse (CelularRecargaProgramadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CelularRecargaProgramadaResponse>> CadastrarAsyncWithHttpInfo (CelularRecargaProgramadaPersist persistencia)
        {
            // verify the required parameter 'persistencia' is set
            if (persistencia == null) throw new ApiException(400, "Missing required parameter 'persistencia' when calling Cadastrar");
            
    
            var localVarPath = "/api/celulares/recargas-programadas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (persistencia.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(persistencia); // http body (model) parameter
            }
            else
            {
                localVarPostBody = persistencia; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CelularRecargaProgramadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CelularRecargaProgramadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CelularRecargaProgramadaResponse)));
            
        }
        
        /// <summary>
        /// Make the Add-ons for an Account This method allows an existing person in the base to be an additional account in the informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>AdicionalContaResponse</returns>
        public AdicionalContaResponse CadastrarAdicional (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = CadastrarAdicionalWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Make the Add-ons for an Account This method allows an existing person in the base to be an additional account in the informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param> 
        /// <param name="adicionalContaPersist">adicionalContaPersist</param> 
        /// <returns>ApiResponse of AdicionalContaResponse</returns>
        public ApiResponse< AdicionalContaResponse > CadastrarAdicionalWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->CadastrarAdicional");
            
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null)
                throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling RegisterClientApi->CadastrarAdicional");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (adicionalContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalContaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }

        
        /// <summary>
        /// Make the Add-ons for an Account This method allows an existing person in the base to be an additional account in the informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of AdicionalContaResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalContaResponse> CadastrarAdicionalAsync (long? id, AdicionalContaPersist adicionalContaPersist)
        {
             ApiResponse<AdicionalContaResponse> localVarResponse = await CadastrarAdicionalAsyncWithHttpInfo(id, adicionalContaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Make the Add-ons for an Account This method allows an existing person in the base to be an additional account in the informed
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Code of identification of the account (id)</param>
        /// <param name="adicionalContaPersist">adicionalContaPersist</param>
        /// <returns>Task of ApiResponse (AdicionalContaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalContaResponse>> CadastrarAdicionalAsyncWithHttpInfo (long? id, AdicionalContaPersist adicionalContaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CadastrarAdicional");
            // verify the required parameter 'adicionalContaPersist' is set
            if (adicionalContaPersist == null) throw new ApiException(400, "Missing required parameter 'adicionalContaPersist' when calling CadastrarAdicional");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (adicionalContaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(adicionalContaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = adicionalContaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CadastrarAdicional: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalContaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalContaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalContaResponse)));
            
        }
        
        /// <summary>
        /// Create the Register of Additional for an Account This method allows to be created an additional carrier for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse Cadastrar_0 (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = Cadastrar_0WithHttpInfo(id, persist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create the Register of Additional for an Account This method allows to be created an additional carrier for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param> 
        /// <param name="persist">persist</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > Cadastrar_0WithHttpInfo (long? id, AdicionalPersist persist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Cadastrar_0");
            
            // verify the required parameter 'persist' is set
            if (persist == null)
                throw new ApiException(400, "Missing required parameter 'persist' when calling RegisterClientApi->Cadastrar_0");
            
    
            var localVarPath = "/api/contas/{id}/cadastrar-adicional";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Create the Register of Additional for an Account This method allows to be created an additional carrier for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> Cadastrar_0Async (long? id, AdicionalPersist persist)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await Cadastrar_0AsyncWithHttpInfo(id, persist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create the Register of Additional for an Account This method allows to be created an additional carrier for a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Account (id)</param>
        /// <param name="persist">persist</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> Cadastrar_0AsyncWithHttpInfo (long? id, AdicionalPersist persist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Cadastrar_0");
            // verify the required parameter 'persist' is set
            if (persist == null) throw new ApiException(400, "Missing required parameter 'persist' when calling Cadastrar_0");
            
    
            var localVarPath = "/api/contas/{id}/cadastrar-adicional";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Cadastrar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Creating additional account This method allows to be  consulted an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id)</param> 
        /// <returns>AdicionalDetalheResponse</returns>
        public AdicionalDetalheResponse Consultar (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = ConsultarWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creating additional account This method allows to be  consulted an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id)</param> 
        /// <returns>ApiResponse of AdicionalDetalheResponse</returns>
        public ApiResponse< AdicionalDetalheResponse > ConsultarWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Consultar");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling RegisterClientApi->Consultar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }

        
        /// <summary>
        /// Creating additional account This method allows to be  consulted an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of AdicionalDetalheResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalDetalheResponse> ConsultarAsync (long? id, long? idPessoa)
        {
             ApiResponse<AdicionalDetalheResponse> localVarResponse = await ConsultarAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creating additional account This method allows to be  consulted an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of ApiResponse (AdicionalDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalDetalheResponse>> ConsultarAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Consultar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalDetalheResponse)));
            
        }
        
        /// <summary>
        /// Show the dates of a determined Address This resource allows to retrieve a determined address using the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse Consultar_0 (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = Consultar_0WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Show the dates of a determined Address This resource allows to retrieve a determined address using the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > Consultar_0WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Consultar_0");
            
    
            var localVarPath = "/api/enderecos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Show the dates of a determined Address This resource allows to retrieve a determined address using the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> Consultar_0Async (long? id)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await Consultar_0AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Show the dates of a determined Address This resource allows to retrieve a determined address using the id code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Address (id)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Consultar_0AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_0");
            
    
            var localVarPath = "/api/enderecos/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// List the details of a determined person This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse Consultar_1 (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = Consultar_1WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the details of a determined person This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > Consultar_1WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Consultar_1");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// List the details of a determined person This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> Consultar_1Async (long? id)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await Consultar_1AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the details of a determined person This method allows to retrieve the details of a Person existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Consultar_1AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_1");
            
    
            var localVarPath = "/api/pessoas-detalhes/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined Person This method allows to be listed the People existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse Consultar_2 (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = Consultar_2WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Person This method allows to be listed the People existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > Consultar_2WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Consultar_2");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Person This method allows to be listed the People existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> Consultar_2Async (long? id)
        {
             ApiResponse<PessoaResponse> localVarResponse = await Consultar_2AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Person This method allows to be listed the People existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the Person</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Consultar_2AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_2");
            
    
            var localVarPath = "/api/pessoas/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// List the dates of a determined Telephone This method allows to retrieve a determined telephone using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse Consultar_3 (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = Consultar_3WithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the dates of a determined Telephone This method allows to retrieve a determined telephone using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > Consultar_3WithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Consultar_3");
            
    
            var localVarPath = "/api/telefones/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// List the dates of a determined Telephone This method allows to retrieve a determined telephone using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> Consultar_3Async (long? id)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await Consultar_3AsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the dates of a determined Telephone This method allows to retrieve a determined telephone using its identification code (id)
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the Telephone (id)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Consultar_3AsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Consultar_3");
            
    
            var localVarPath = "/api/telefones/{id}";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Consultar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
        /// <summary>
        /// Inactive Additional of an Account This method allows tobe inactived an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id)</param> 
        /// <returns>string</returns>
        public string Inativar (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = InativarWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Inactive Additional of an Account This method allows tobe inactived an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id)</param> 
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > InativarWithHttpInfo (long? id, long? idPessoa)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Inativar");
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling RegisterClientApi->Inativar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}/inativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        
        /// <summary>
        /// Inactive Additional of an Account This method allows tobe inactived an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> InativarAsync (long? id, long? idPessoa)
        {
             ApiResponse<string> localVarResponse = await InativarAsyncWithHttpInfo(id, idPessoa);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Inactive Additional of an Account This method allows tobe inactived an additional carrier of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the account (id)</param>
        /// <param name="idPessoa">Identification Code of the Person (id)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> InativarAsyncWithHttpInfo (long? id, long? idPessoa)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Inativar");
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Inativar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais/{idPessoa}/inativar";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarPathParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // path parameter
            
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Inativar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }
        
        /// <summary>
        /// List the additionals of an account This method allows to be listed additional carriers of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>AdicionalResponse</returns>
        public AdicionalResponse Listar (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = ListarWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the additionals of an account This method allows to be listed additional carriers of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of AdicionalResponse</returns>
        public ApiResponse< AdicionalResponse > ListarWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Listar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }

        
        /// <summary>
        /// List the additionals of an account This method allows to be listed additional carriers of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of AdicionalResponse</returns>
        public async System.Threading.Tasks.Task<AdicionalResponse> ListarAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<AdicionalResponse> localVarResponse = await ListarAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the additionals of an account This method allows to be listed additional carriers of a determined account
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the account (id)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (AdicionalResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AdicionalResponse>> ListarAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Listar");
            
    
            var localVarPath = "/api/contas/{id}/adicionais";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AdicionalResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AdicionalResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AdicionalResponse)));
            
        }
        
        /// <summary>
        /// List the account of the person Allow to list the accounts of a person using the number at the IRs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PageContaDetalheResponse</returns>
        public PageContaDetalheResponse ListarContasPorPessoa (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = ListarContasPorPessoaWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the account of the person Allow to list the accounts of a person using the number at the IRs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PageContaDetalheResponse</returns>
        public ApiResponse< PageContaDetalheResponse > ListarContasPorPessoaWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null)
                throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling RegisterClientApi->ListarContasPorPessoa");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }

        
        /// <summary>
        /// List the account of the person Allow to list the accounts of a person using the number at the IRs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PageContaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PageContaDetalheResponse> ListarContasPorPessoaAsync (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PageContaDetalheResponse> localVarResponse = await ListarContasPorPessoaAsyncWithHttpInfo(numeroReceitaFederal, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the account of the person Allow to list the accounts of a person using the number at the IRs
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="numeroReceitaFederal">Identification Number of the client in the IRs (CPF or CNPJ)</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PageContaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageContaDetalheResponse>> ListarContasPorPessoaAsyncWithHttpInfo (string numeroReceitaFederal, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'numeroReceitaFederal' is set
            if (numeroReceitaFederal == null) throw new ApiException(400, "Missing required parameter 'numeroReceitaFederal' when calling ListarContasPorPessoa");
            
    
            var localVarPath = "/api/pessoas/listar-contas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarContasPorPessoa: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageContaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageContaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageContaDetalheResponse)));
            
        }
        
        /// <summary>
        /// List the updates of telephones made in the last 60 days This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param> 
        /// <returns>HistoricoTelefoneResponse</returns>
        public HistoricoTelefoneResponse ListarHistoricoTelefones (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = ListarHistoricoTelefonesWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the updates of telephones made in the last 60 days This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param> 
        /// <returns>ApiResponse of HistoricoTelefoneResponse</returns>
        public ApiResponse< HistoricoTelefoneResponse > ListarHistoricoTelefonesWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->ListarHistoricoTelefones");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }

        
        /// <summary>
        /// List the updates of telephones made in the last 60 days This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param>
        /// <returns>Task of HistoricoTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<HistoricoTelefoneResponse> ListarHistoricoTelefonesAsync (long? id)
        {
             ApiResponse<HistoricoTelefoneResponse> localVarResponse = await ListarHistoricoTelefonesAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the updates of telephones made in the last 60 days This method allows to verify what the telephones of a determined client were updated in the last 60 days
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification Code of the person (id)</param>
        /// <returns>Task of ApiResponse (HistoricoTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HistoricoTelefoneResponse>> ListarHistoricoTelefonesAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarHistoricoTelefones");
            
    
            var localVarPath = "/api/pessoas/{id}/historico-telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarHistoricoTelefones: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<HistoricoTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HistoricoTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HistoricoTelefoneResponse)));
            
        }
        
        /// <summary>
        /// List partners of a legal entity Lista the partners linked to a legal entity registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse ListarSocios (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = ListarSociosWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List partners of a legal entity Lista the partners linked to a legal entity registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param> 
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > ListarSociosWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->ListarSocios");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas/{id}/socios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// List partners of a legal entity Lista the partners linked to a legal entity registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> ListarSociosAsync (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await ListarSociosAsyncWithHttpInfo(id, sort, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List partners of a legal entity Lista the partners linked to a legal entity registered
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Identification code of the Legal Person</param>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> ListarSociosAsyncWithHttpInfo (long? id, List<string> sort = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ListarSocios");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas/{id}/socios";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ListarSocios: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// List the addresses created by the Issuer This resource allows to be listed the addresses in the datababse of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Address (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param> 
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param> 
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param> 
        /// <param name="logradouro">List the name of the Street (optional)</param> 
        /// <param name="numero">List the number of address (optional)</param> 
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param> 
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param> 
        /// <param name="bairro">List the name of the neighborhood (optional)</param> 
        /// <param name="cidade">List the name of the city (optional)</param> 
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param> 
        /// <param name="pais">List the name of the Country (optional)</param> 
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param> 
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param> 
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param> 
        /// <returns>PageEnderecoResponse</returns>
        public PageEnderecoResponse Listar_0 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = Listar_0WithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the addresses created by the Issuer This resource allows to be listed the addresses in the datababse of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Address (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param> 
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param> 
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param> 
        /// <param name="logradouro">List the name of the Street (optional)</param> 
        /// <param name="numero">List the number of address (optional)</param> 
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param> 
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param> 
        /// <param name="bairro">List the name of the neighborhood (optional)</param> 
        /// <param name="cidade">List the name of the city (optional)</param> 
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param> 
        /// <param name="pais">List the name of the Country (optional)</param> 
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param> 
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param> 
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param> 
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param> 
        /// <returns>ApiResponse of PageEnderecoResponse</returns>
        public ApiResponse< PageEnderecoResponse > Listar_0WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (dataUltimaAtualizacao != null) localVarQueryParams.Add("dataUltimaAtualizacao", Configuration.ApiClient.ParameterToString(dataUltimaAtualizacao)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }

        
        /// <summary>
        /// List the addresses created by the Issuer This resource allows to be listed the addresses in the datababse of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Address (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param>
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param>
        /// <param name="logradouro">List the name of the Street (optional)</param>
        /// <param name="numero">List the number of address (optional)</param>
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param>
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param>
        /// <param name="bairro">List the name of the neighborhood (optional)</param>
        /// <param name="cidade">List the name of the city (optional)</param>
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param>
        /// <param name="pais">List the name of the Country (optional)</param>
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param>
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <returns>Task of PageEnderecoResponse</returns>
        public async System.Threading.Tasks.Task<PageEnderecoResponse> Listar_0Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
             ApiResponse<PageEnderecoResponse> localVarResponse = await Listar_0AsyncWithHttpInfo(sort, page, limit, id, idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, dataInclusao, dataUltimaAtualizacao, tempoResidenciaAnos, tempoResidenciaMeses);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the addresses created by the Issuer This resource allows to be listed the addresses in the datababse of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Address (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Type of Address (id) (optional)</param>
        /// <param name="cep">List the ZIP Code of the Address (CEP) (optional)</param>
        /// <param name="logradouro">List the name of the Street (optional)</param>
        /// <param name="numero">List the number of address (optional)</param>
        /// <param name="complemento">List complementary descriptions refering to the Address (optional)</param>
        /// <param name="pontoReferencia">List the description of the reference of the address (optional)</param>
        /// <param name="bairro">List the name of the neighborhood (optional)</param>
        /// <param name="cidade">List the name of the city (optional)</param>
        /// <param name="uf">List the acronym of the Federal Unity (optional)</param>
        /// <param name="pais">List the name of the Country (optional)</param>
        /// <param name="dataInclusao">List the date that the address was registered (optional)</param>
        /// <param name="dataUltimaAtualizacao">Date when was made the last update in this register of the address. When it didn&#39;t occur any update, it will have the same information as the field dateInclusion (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <returns>Task of ApiResponse (PageEnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageEnderecoResponse>> Listar_0AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, string dataInclusao = null, string dataUltimaAtualizacao = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (dataInclusao != null) localVarQueryParams.Add("dataInclusao", Configuration.ApiClient.ParameterToString(dataInclusao)); // query parameter
            if (dataUltimaAtualizacao != null) localVarQueryParams.Add("dataUltimaAtualizacao", Configuration.ApiClient.ParameterToString(dataUltimaAtualizacao)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageEnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageEnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageEnderecoResponse)));
            
        }
        
        /// <summary>
        /// List the People registered in the Issuer This method allows to be listed the People existent in the database of issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Person (id) (optional)</param> 
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param> 
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param> 
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param> 
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param> 
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param> 
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param> 
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param> 
        /// <returns>PagePessoaResponse</returns>
        public PagePessoaResponse Listar_1 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = Listar_1WithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the People registered in the Issuer This method allows to be listed the People existent in the database of issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Person (id) (optional)</param> 
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param> 
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param> 
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param> 
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param> 
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param> 
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param> 
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param> 
        /// <returns>ApiResponse of PagePessoaResponse</returns>
        public ApiResponse< PagePessoaResponse > Listar_1WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
    
            var localVarPath = "/api/pessoas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }

        
        /// <summary>
        /// List the People registered in the Issuer This method allows to be listed the People existent in the database of issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Person (id) (optional)</param>
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param>
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param>
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param>
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param>
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param>
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param>
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param>
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param>
        /// <returns>Task of PagePessoaResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaResponse> Listar_1Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PagePessoaResponse> localVarResponse = await Listar_1AsyncWithHttpInfo(sort, page, limit, id, nome, tipo, cpf, cnpj, dataNascimento, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the People registered in the Issuer This method allows to be listed the People existent in the database of issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Person (id) (optional)</param>
        /// <param name="nome">Shows the &#39;Full name of the PP&#39; or the &#39;Full name of the Social Reason (Business Name)&#39; (optional)</param>
        /// <param name="tipo">Identification Code of the Physical Person, being: (&#39;PP&#39;: Physical Person), (&#39;LP&#39;: Legal Person) (optional)</param>
        /// <param name="cpf">Number of CPF, whe it is PP (optional)</param>
        /// <param name="cnpj">Number of CNPJ, when it is LP (optional)</param>
        /// <param name="dataNascimento">Born date of the Person, when it is PP, or date of the Business Opening, when it is Legal Person (optional)</param>
        /// <param name="sexo">Identification Code of sex of the Person, When it is PP, being: (&#39;M&#39;: Male), (&#39;F&#39;: Female), (&#39;O&#39;: Other), (&#39;N&#39;: Not specifie) (optional)</param>
        /// <param name="numeroIdentidade">Number of Identity Document (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Organ issuer of the ID card (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of Federal Unity where was issued the Document (optional)</param>
        /// <param name="dataEmissaoIdentidade">Date of issue of the identity document in format yyyy-MM-dd (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaResponse>> Listar_1AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, string nome = null, string tipo = null, string cpf = null, string cnpj = null, string dataNascimento = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
    
            var localVarPath = "/api/pessoas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaResponse)));
            
        }
        
        /// <summary>
        /// List the details of the people registered in the issuer This method allows to be listed the details of the people existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idPessoa">Identifier Code of the person (optional)</param> 
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param> 
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param> 
        /// <param name="idProfissao">Occupation of the physical person (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param> 
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param> 
        /// <param name="numeroBanco">Number of the Bank (optional)</param> 
        /// <param name="numeroAgencia">Number of the Agency (optional)</param> 
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param> 
        /// <param name="email">Email of the physical person (optional)</param> 
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param> 
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param> 
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param> 
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param> 
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param> 
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param> 
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param> 
        /// <returns>PagePessoaDetalheResponse</returns>
        public PagePessoaDetalheResponse Listar_2 (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = Listar_2WithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the details of the people registered in the issuer This method allows to be listed the details of the people existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="idPessoa">Identifier Code of the person (optional)</param> 
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param> 
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param> 
        /// <param name="idProfissao">Occupation of the physical person (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param> 
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param> 
        /// <param name="numeroBanco">Number of the Bank (optional)</param> 
        /// <param name="numeroAgencia">Number of the Agency (optional)</param> 
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param> 
        /// <param name="email">Email of the physical person (optional)</param> 
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param> 
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param> 
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param> 
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param> 
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param> 
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param> 
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param> 
        /// <returns>ApiResponse of PagePessoaDetalheResponse</returns>
        public ApiResponse< PagePessoaDetalheResponse > Listar_2WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// List the details of the people registered in the issuer This method allows to be listed the details of the people existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">Identifier Code of the person (optional)</param>
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the Bank (optional)</param>
        /// <param name="numeroAgencia">Number of the Agency (optional)</param>
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of PagePessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PagePessoaDetalheResponse> Listar_2Async (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PagePessoaDetalheResponse> localVarResponse = await Listar_2AsyncWithHttpInfo(sort, page, limit, idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the details of the people registered in the issuer This method allows to be listed the details of the people existent in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="idPessoa">Identifier Code of the person (optional)</param>
        /// <param name="nomeMae">Shows the name of the mother physical person (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical person (optional)</param>
        /// <param name="idProfissao">Occupation of the physical person (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationallity of the physical person (optional)</param>
        /// <param name="numeroBanco">Number of the Bank (optional)</param>
        /// <param name="numeroAgencia">Number of the Agency (optional)</param>
        /// <param name="numeroContaCorrente">Number of the current account (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that may be printed on the card (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of ApiResponse (PagePessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PagePessoaDetalheResponse>> Listar_2AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? idPessoa = null, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PagePessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PagePessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PagePessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// List the Telephones registered in the Issuer This method allows to be listed the telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param> 
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param> 
        /// <param name="ddd">Telephone DDD (id) (optional)</param> 
        /// <param name="telefone">Telephone number (optional)</param> 
        /// <param name="ramal">Extension Number (optional)</param> 
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param> 
        /// <returns>PageTelefoneResponse</returns>
        public PageTelefoneResponse Listar_3 (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = Listar_3WithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;
        }

        /// <summary>
        /// List the Telephones registered in the Issuer This method allows to be listed the telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param> 
        /// <param name="page">Page (optional)</param> 
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param> 
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param> 
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param> 
        /// <param name="ddd">Telephone DDD (id) (optional)</param> 
        /// <param name="telefone">Telephone number (optional)</param> 
        /// <param name="ramal">Extension Number (optional)</param> 
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param> 
        /// <returns>ApiResponse of PageTelefoneResponse</returns>
        public ApiResponse< PageTelefoneResponse > Listar_3WithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }

        
        /// <summary>
        /// List the Telephones registered in the Issuer This method allows to be listed the telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param>
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">Telephone DDD (id) (optional)</param>
        /// <param name="telefone">Telephone number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param>
        /// <returns>Task of PageTelefoneResponse</returns>
        public async System.Threading.Tasks.Task<PageTelefoneResponse> Listar_3Async (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
             ApiResponse<PageTelefoneResponse> localVarResponse = await Listar_3AsyncWithHttpInfo(sort, page, limit, id, idTipoTelefone, idPessoa, ddd, telefone, ramal, status);
             return localVarResponse.Data;

        }

        /// <summary>
        /// List the Telephones registered in the Issuer This method allows to be listed the telephones in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sort">Register ordering type (optional)</param>
        /// <param name="page">Page (optional)</param>
        /// <param name="limit">Limit of elements per request (Default =50, Max =50) (optional)</param>
        /// <param name="id">Identification Code of the Telephone (id) (optional)</param>
        /// <param name="idTipoTelefone">Identification Code of Type of the Telephone (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">Telephone DDD (id) (optional)</param>
        /// <param name="telefone">Telephone number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <param name="status">Shows the Status of the TElephone, where: &#39;0&#39;: Inactive and &#39;1&#39;: Active? (optional)</param>
        /// <returns>Task of ApiResponse (PageTelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTelefoneResponse>> Listar_3AsyncWithHttpInfo (List<string> sort = null, int? page = null, int? limit = null, long? id = null, long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null, int? status = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            if (status != null) localVarQueryParams.Add("status", Configuration.ApiClient.ParameterToString(status)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Listar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PageTelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PageTelefoneResponse)));
            
        }
        
        /// <summary>
        /// Include an account as a register for integration This resource allows to include an account as a register for integration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param> 
        /// <param name="body">IntegracaoEmissorPersist (optional)</param> 
        /// <returns>IntegracaoEmissorResponse</returns>
        public IntegracaoEmissorResponse Salvar (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = SalvarWithHttpInfo(id, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Include an account as a register for integration This resource allows to include an account as a register for integration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param> 
        /// <param name="body">IntegracaoEmissorPersist (optional)</param> 
        /// <returns>ApiResponse of IntegracaoEmissorResponse</returns>
        public ApiResponse< IntegracaoEmissorResponse > SalvarWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->Salvar");
            
    
            var localVarPath = "/api/contas/{id}/incluir-registro-integracao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }

        
        /// <summary>
        /// Include an account as a register for integration This resource allows to include an account as a register for integration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of IntegracaoEmissorResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorResponse> SalvarAsync (long? id, IntegracaoEmissorPersist body = null)
        {
             ApiResponse<IntegracaoEmissorResponse> localVarResponse = await SalvarAsyncWithHttpInfo(id, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Include an account as a register for integration This resource allows to include an account as a register for integration
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">idConta</param>
        /// <param name="body">IntegracaoEmissorPersist (optional)</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorResponse>> SalvarAsyncWithHttpInfo (long? id, IntegracaoEmissorPersist body = null)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling Salvar");
            
    
            var localVarPath = "/api/contas/{id}/incluir-registro-integracao";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorResponse)));
            
        }
        
        /// <summary>
        /// Create the Account and Legal Entity Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ObjectApprovedIndividual</returns>
        public ObjectApprovedIndividual SalvarPessoaFisicaAprovada (ObjectApprovedIndividual pessoaPersist)
        {
             ApiResponse<ObjectApprovedIndividual> localVarResponse = SalvarPessoaFisicaAprovadaWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create the Account and Legal Entity Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of ObjectApprovedIndividual</returns>
        public ApiResponse< ObjectApprovedIndividual > SalvarPessoaFisicaAprovadaWithHttpInfo (ObjectApprovedIndividual pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling RegisterClientApi->SalvarPessoaFisicaAprovada");
            
    
            var localVarPath = "/api/clientes-pessoas-fisicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<ObjectApprovedIndividual>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObjectApprovedIndividual) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjectApprovedIndividual)));
            
        }

        
        /// <summary>
        /// Create the Account and Legal Entity Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ObjectApprovedIndividual</returns>
        public async System.Threading.Tasks.Task<ObjectApprovedIndividual> SalvarPessoaFisicaAprovadaAsync (ObjectApprovedIndividual pessoaPersist)
        {
             ApiResponse<ObjectApprovedIndividual> localVarResponse = await SalvarPessoaFisicaAprovadaAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create the Account and Legal Entity Allow to create the register of an Account Legal Entity one, recieving in this operation all the register dates which are necessary for this. Once created, It can be turn on the method Card Creation for the client and their additionals
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (ObjectApprovedIndividual)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ObjectApprovedIndividual>> SalvarPessoaFisicaAprovadaAsyncWithHttpInfo (ObjectApprovedIndividual pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaFisicaAprovada");
            
    
            var localVarPath = "/api/clientes-pessoas-fisicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaFisicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ObjectApprovedIndividual>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ObjectApprovedIndividual) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ObjectApprovedIndividual)));
            
        }
        
        /// <summary>
        /// Create the Account and Legal Entity Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>PessoaJuridicaAprovadaResponse</returns>
        public PessoaJuridicaAprovadaResponse SalvarPessoaJuridicaAprovada (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = SalvarPessoaJuridicaAprovadaWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create the Account and Legal Entity Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param> 
        /// <returns>ApiResponse of PessoaJuridicaAprovadaResponse</returns>
        public ApiResponse< PessoaJuridicaAprovadaResponse > SalvarPessoaJuridicaAprovadaWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null)
                throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling RegisterClientApi->SalvarPessoaJuridicaAprovada");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }

        
        /// <summary>
        /// Create the Account and Legal Entity Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of PessoaJuridicaAprovadaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaJuridicaAprovadaResponse> SalvarPessoaJuridicaAprovadaAsync (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
             ApiResponse<PessoaJuridicaAprovadaResponse> localVarResponse = await SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo(pessoaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create the Account and Legal Entity Create the Account and Legal Entity allows to do the register of an account for a client  Legal Entity one, recieving in this operation all the register dates which are necessary for this, including the register of each one of the linked partners
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pessoaPersist">pessoaPersist</param>
        /// <returns>Task of ApiResponse (PessoaJuridicaAprovadaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaJuridicaAprovadaResponse>> SalvarPessoaJuridicaAprovadaAsyncWithHttpInfo (PessoaJuridicaAprovadaPersist pessoaPersist)
        {
            // verify the required parameter 'pessoaPersist' is set
            if (pessoaPersist == null) throw new ApiException(400, "Missing required parameter 'pessoaPersist' when calling SalvarPessoaJuridicaAprovada");
            
    
            var localVarPath = "/api/clientes-pessoas-juridicas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            
            
            
            if (pessoaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(pessoaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = pessoaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarPessoaJuridicaAprovada: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaJuridicaAprovadaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaJuridicaAprovadaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaJuridicaAprovadaResponse)));
            
        }
        
        /// <summary>
        /// Includes integration record This feature allows you to include an integration record
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>IntegracaoEmissorPropostaResponse</returns>
        public IntegracaoEmissorPropostaResponse SalvarRegistroIntegracaoManager (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = SalvarRegistroIntegracaoManagerWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Includes integration record This feature allows you to include an integration record
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param> 
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param> 
        /// <returns>ApiResponse of IntegracaoEmissorPropostaResponse</returns>
        public ApiResponse< IntegracaoEmissorPropostaResponse > SalvarRegistroIntegracaoManagerWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling RegisterClientApi->SalvarRegistroIntegracaoManager");
            
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null)
                throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling RegisterClientApi->SalvarRegistroIntegracaoManager");
            
    
            var localVarPath = "/api/contas/{id}/registros-integracao-manager";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (integracaoEmissorPropostaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integracaoEmissorPropostaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integracaoEmissorPropostaPersist; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }

        
        /// <summary>
        /// Includes integration record This feature allows you to include an integration record
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of IntegracaoEmissorPropostaResponse</returns>
        public async System.Threading.Tasks.Task<IntegracaoEmissorPropostaResponse> SalvarRegistroIntegracaoManagerAsync (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
             ApiResponse<IntegracaoEmissorPropostaResponse> localVarResponse = await SalvarRegistroIntegracaoManagerAsyncWithHttpInfo(id, integracaoEmissorPropostaPersist);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Includes integration record This feature allows you to include an integration record
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Account Identifier</param>
        /// <param name="integracaoEmissorPropostaPersist">integracaoEmissorPropostaPersist</param>
        /// <returns>Task of ApiResponse (IntegracaoEmissorPropostaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<IntegracaoEmissorPropostaResponse>> SalvarRegistroIntegracaoManagerAsyncWithHttpInfo (long? id, IntegracaoEmissorPropostaPersist integracaoEmissorPropostaPersist)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SalvarRegistroIntegracaoManager");
            // verify the required parameter 'integracaoEmissorPropostaPersist' is set
            if (integracaoEmissorPropostaPersist == null) throw new ApiException(400, "Missing required parameter 'integracaoEmissorPropostaPersist' when calling SalvarRegistroIntegracaoManager");
            
    
            var localVarPath = "/api/contas/{id}/registros-integracao-manager";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
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
            
            
            
            
            if (integracaoEmissorPropostaPersist.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(integracaoEmissorPropostaPersist); // http body (model) parameter
            }
            else
            {
                localVarPostBody = integracaoEmissorPropostaPersist; // byte array
            }

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling SalvarRegistroIntegracaoManager: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<IntegracaoEmissorPropostaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (IntegracaoEmissorPropostaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(IntegracaoEmissorPropostaResponse)));
            
        }
        
        /// <summary>
        /// Create a register of a new Address This resource allows to be created a new Address in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param> 
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param> 
        /// <param name="cep">CEP (optional)</param> 
        /// <param name="logradouro">Show the Street name (optional)</param> 
        /// <param name="numero">Show the number of the address (optional)</param> 
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param> 
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param> 
        /// <param name="bairro">Show the name of the neighborhood (optional)</param> 
        /// <param name="cidade">Show the name of the city (optional)</param> 
        /// <param name="uf">Show Federal Unity Acronym (optional)</param> 
        /// <param name="pais">Show the name of the Country (optional)</param> 
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param> 
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param> 
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param> 
        /// <returns>EnderecoResponse</returns>
        public EnderecoResponse Salvar_0 (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = Salvar_0WithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a register of a new Address This resource allows to be created a new Address in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param> 
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param> 
        /// <param name="cep">CEP (optional)</param> 
        /// <param name="logradouro">Show the Street name (optional)</param> 
        /// <param name="numero">Show the number of the address (optional)</param> 
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param> 
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param> 
        /// <param name="bairro">Show the name of the neighborhood (optional)</param> 
        /// <param name="cidade">Show the name of the city (optional)</param> 
        /// <param name="uf">Show Federal Unity Acronym (optional)</param> 
        /// <param name="pais">Show the name of the Country (optional)</param> 
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param> 
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param> 
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param> 
        /// <returns>ApiResponse of EnderecoResponse</returns>
        public ApiResponse< EnderecoResponse > Salvar_0WithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }

        
        /// <summary>
        /// Create a register of a new Address This resource allows to be created a new Address in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of EnderecoResponse</returns>
        public async System.Threading.Tasks.Task<EnderecoResponse> Salvar_0Async (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
             ApiResponse<EnderecoResponse> localVarResponse = await Salvar_0AsyncWithHttpInfo(idPessoa, idTipoEndereco, cep, logradouro, numero, complemento, pontoReferencia, bairro, cidade, uf, pais, tempoResidenciaAnos, tempoResidenciaMeses, aplicativoAlteracao);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a register of a new Address This resource allows to be created a new Address in the database of the Issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Identification Code of the Person which the address belongs (id) (optional)</param>
        /// <param name="idTipoEndereco">Identification Code of the Address Type (id) (optional)</param>
        /// <param name="cep">CEP (optional)</param>
        /// <param name="logradouro">Show the Street name (optional)</param>
        /// <param name="numero">Show the number of the address (optional)</param>
        /// <param name="complemento">Show complementary descriptions referring to the address (optional)</param>
        /// <param name="pontoReferencia">Show the description of the address landmark (optional)</param>
        /// <param name="bairro">Show the name of the neighborhood (optional)</param>
        /// <param name="cidade">Show the name of the city (optional)</param>
        /// <param name="uf">Show Federal Unity Acronym (optional)</param>
        /// <param name="pais">Show the name of the Country (optional)</param>
        /// <param name="tempoResidenciaAnos">Displays the number of years spent living in the residence (optional)</param>
        /// <param name="tempoResidenciaMeses">Displays the number of months spent living in the residence (optional)</param>
        /// <param name="aplicativoAlteracao">Displays the responsible application for the address change (optional)</param>
        /// <returns>Task of ApiResponse (EnderecoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EnderecoResponse>> Salvar_0AsyncWithHttpInfo (long? idPessoa = null, long? idTipoEndereco = null, string cep = null, string logradouro = null, int? numero = null, string complemento = null, string pontoReferencia = null, string bairro = null, string cidade = null, string uf = null, string pais = null, int? tempoResidenciaAnos = null, int? tempoResidenciaMeses = null, string aplicativoAlteracao = null)
        {
            
    
            var localVarPath = "/api/enderecos";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (idTipoEndereco != null) localVarQueryParams.Add("idTipoEndereco", Configuration.ApiClient.ParameterToString(idTipoEndereco)); // query parameter
            if (cep != null) localVarQueryParams.Add("cep", Configuration.ApiClient.ParameterToString(cep)); // query parameter
            if (logradouro != null) localVarQueryParams.Add("logradouro", Configuration.ApiClient.ParameterToString(logradouro)); // query parameter
            if (numero != null) localVarQueryParams.Add("numero", Configuration.ApiClient.ParameterToString(numero)); // query parameter
            if (complemento != null) localVarQueryParams.Add("complemento", Configuration.ApiClient.ParameterToString(complemento)); // query parameter
            if (pontoReferencia != null) localVarQueryParams.Add("pontoReferencia", Configuration.ApiClient.ParameterToString(pontoReferencia)); // query parameter
            if (bairro != null) localVarQueryParams.Add("bairro", Configuration.ApiClient.ParameterToString(bairro)); // query parameter
            if (cidade != null) localVarQueryParams.Add("cidade", Configuration.ApiClient.ParameterToString(cidade)); // query parameter
            if (uf != null) localVarQueryParams.Add("uf", Configuration.ApiClient.ParameterToString(uf)); // query parameter
            if (pais != null) localVarQueryParams.Add("pais", Configuration.ApiClient.ParameterToString(pais)); // query parameter
            if (tempoResidenciaAnos != null) localVarQueryParams.Add("tempoResidenciaAnos", Configuration.ApiClient.ParameterToString(tempoResidenciaAnos)); // query parameter
            if (tempoResidenciaMeses != null) localVarQueryParams.Add("tempoResidenciaMeses", Configuration.ApiClient.ParameterToString(tempoResidenciaMeses)); // query parameter
            if (aplicativoAlteracao != null) localVarQueryParams.Add("aplicativoAlteracao", Configuration.ApiClient.ParameterToString(aplicativoAlteracao)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_0: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EnderecoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EnderecoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EnderecoResponse)));
            
        }
        
        /// <summary>
        /// Create the register of a new Person this method allows to be registered a new Person in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param> 
        /// <param name="tipo">Kind of Person (PF or PJ)</param> 
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param> 
        /// <param name="cpf">CPF number, when it is PF (optional)</param> 
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param> 
        /// <param name="sexo">Person Gender (optional)</param> 
        /// <param name="numeroIdentidade">Identity Number (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param> 
        /// <returns>PessoaResponse</returns>
        public PessoaResponse Salvar_1 (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = Salvar_1WithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create the register of a new Person this method allows to be registered a new Person in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param> 
        /// <param name="tipo">Kind of Person (PF or PJ)</param> 
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param> 
        /// <param name="cpf">CPF number, when it is PF (optional)</param> 
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param> 
        /// <param name="sexo">Person Gender (optional)</param> 
        /// <param name="numeroIdentidade">Identity Number (optional)</param> 
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param> 
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param> 
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param> 
        /// <returns>ApiResponse of PessoaResponse</returns>
        public ApiResponse< PessoaResponse > Salvar_1WithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            
            // verify the required parameter 'nome' is set
            if (nome == null)
                throw new ApiException(400, "Missing required parameter 'nome' when calling RegisterClientApi->Salvar_1");
            
            // verify the required parameter 'tipo' is set
            if (tipo == null)
                throw new ApiException(400, "Missing required parameter 'tipo' when calling RegisterClientApi->Salvar_1");
            
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null)
                throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling RegisterClientApi->Salvar_1");
            
    
            var localVarPath = "/api/pessoas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }

        
        /// <summary>
        /// Create the register of a new Person this method allows to be registered a new Person in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of PessoaResponse</returns>
        public async System.Threading.Tasks.Task<PessoaResponse> Salvar_1Async (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
             ApiResponse<PessoaResponse> localVarResponse = await Salvar_1AsyncWithHttpInfo(nome, tipo, dataNascimento, cpf, cnpj, sexo, numeroIdentidade, orgaoExpedidorIdentidade, unidadeFederativaIdentidade, dataEmissaoIdentidade);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create the register of a new Person this method allows to be registered a new Person in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="nome">Full Name of the PF or Full Name of Corporate Name (Company Name)</param>
        /// <param name="tipo">Kind of Person (PF or PJ)</param>
        /// <param name="dataNascimento">Birth date of the persosn, when PP, or the date of the business opening, when it is LP. This date must be informed in the format yyyy-MM-dd</param>
        /// <param name="cpf">CPF number, when it is PF (optional)</param>
        /// <param name="cnpj">CNPJ number, when it is PJ (optional)</param>
        /// <param name="sexo">Person Gender (optional)</param>
        /// <param name="numeroIdentidade">Identity Number (optional)</param>
        /// <param name="orgaoExpedidorIdentidade">Issue organ of the ID (optional)</param>
        /// <param name="unidadeFederativaIdentidade">Acronym of the Federal Unity where it was issued the Identity (optional)</param>
        /// <param name="dataEmissaoIdentidade">Issue date of the Identity (optional)</param>
        /// <returns>Task of ApiResponse (PessoaResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaResponse>> Salvar_1AsyncWithHttpInfo (string nome, string tipo, string dataNascimento, string cpf = null, string cnpj = null, string sexo = null, string numeroIdentidade = null, string orgaoExpedidorIdentidade = null, string unidadeFederativaIdentidade = null, string dataEmissaoIdentidade = null)
        {
            // verify the required parameter 'nome' is set
            if (nome == null) throw new ApiException(400, "Missing required parameter 'nome' when calling Salvar_1");
            // verify the required parameter 'tipo' is set
            if (tipo == null) throw new ApiException(400, "Missing required parameter 'tipo' when calling Salvar_1");
            // verify the required parameter 'dataNascimento' is set
            if (dataNascimento == null) throw new ApiException(400, "Missing required parameter 'dataNascimento' when calling Salvar_1");
            
    
            var localVarPath = "/api/pessoas";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (nome != null) localVarQueryParams.Add("nome", Configuration.ApiClient.ParameterToString(nome)); // query parameter
            if (tipo != null) localVarQueryParams.Add("tipo", Configuration.ApiClient.ParameterToString(tipo)); // query parameter
            if (cpf != null) localVarQueryParams.Add("cpf", Configuration.ApiClient.ParameterToString(cpf)); // query parameter
            if (cnpj != null) localVarQueryParams.Add("cnpj", Configuration.ApiClient.ParameterToString(cnpj)); // query parameter
            if (dataNascimento != null) localVarQueryParams.Add("dataNascimento", Configuration.ApiClient.ParameterToString(dataNascimento)); // query parameter
            if (sexo != null) localVarQueryParams.Add("sexo", Configuration.ApiClient.ParameterToString(sexo)); // query parameter
            if (numeroIdentidade != null) localVarQueryParams.Add("numeroIdentidade", Configuration.ApiClient.ParameterToString(numeroIdentidade)); // query parameter
            if (orgaoExpedidorIdentidade != null) localVarQueryParams.Add("orgaoExpedidorIdentidade", Configuration.ApiClient.ParameterToString(orgaoExpedidorIdentidade)); // query parameter
            if (unidadeFederativaIdentidade != null) localVarQueryParams.Add("unidadeFederativaIdentidade", Configuration.ApiClient.ParameterToString(unidadeFederativaIdentidade)); // query parameter
            if (dataEmissaoIdentidade != null) localVarQueryParams.Add("dataEmissaoIdentidade", Configuration.ApiClient.ParameterToString(dataEmissaoIdentidade)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_1: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaResponse)));
            
        }
        
        /// <summary>
        /// Save the details of a determined Person This method allows to be included in the base of the issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param> 
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param> 
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param> 
        /// <param name="idProfissao">Physical person occupation (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param> 
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param> 
        /// <param name="numeroBanco">Bank number (optional)</param> 
        /// <param name="numeroAgencia">Agency number (optional)</param> 
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param> 
        /// <param name="email">Email of the physical person (optional)</param> 
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param> 
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param> 
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param> 
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param> 
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param> 
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param> 
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param> 
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param> 
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param> 
        /// <returns>PessoaDetalheResponse</returns>
        public PessoaDetalheResponse Salvar_2 (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = Salvar_2WithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Save the details of a determined Person This method allows to be included in the base of the issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param> 
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param> 
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param> 
        /// <param name="idProfissao">Physical person occupation (optional)</param> 
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param> 
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param> 
        /// <param name="numeroBanco">Bank number (optional)</param> 
        /// <param name="numeroAgencia">Agency number (optional)</param> 
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param> 
        /// <param name="email">Email of the physical person (optional)</param> 
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param> 
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param> 
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param> 
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param> 
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param> 
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param> 
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param> 
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param> 
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param> 
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param> 
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param> 
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param> 
        /// <returns>ApiResponse of PessoaDetalheResponse</returns>
        public ApiResponse< PessoaDetalheResponse > Salvar_2WithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null)
                throw new ApiException(400, "Missing required parameter 'idPessoa' when calling RegisterClientApi->Salvar_2");
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }

        
        /// <summary>
        /// Save the details of a determined Person This method allows to be included in the base of the issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param>
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param>
        /// <param name="idProfissao">Physical person occupation (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of PessoaDetalheResponse</returns>
        public async System.Threading.Tasks.Task<PessoaDetalheResponse> Salvar_2Async (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
             ApiResponse<PessoaDetalheResponse> localVarResponse = await Salvar_2AsyncWithHttpInfo(idPessoa, nomeMae, idEstadoCivil, idProfissao, idNaturezaOcupacao, idNacionalidade, numeroBanco, numeroAgencia, numeroContaCorrente, email, nomeEmpresa, nomeReferencia1, enderecoReferencia1, nomeReferencia2, enderecoReferencia2, naturalidadeCidade, naturalidadeEstado, grauInstrucao, numeroDependentes, nomePai, chequeEspecial, impedidoFinanciamento);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Save the details of a determined Person This method allows to be included in the base of the issuer the details of a determined Person
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idPessoa">Show the identifier code of the person</param>
        /// <param name="nomeMae">Show the name of the physical person mother (optional)</param>
        /// <param name="idEstadoCivil">Id Marital Status of the Physical Person (optional)</param>
        /// <param name="idProfissao">Physical person occupation (optional)</param>
        /// <param name="idNaturezaOcupacao">Id Occupation of the physical person (optional)</param>
        /// <param name="idNacionalidade">Id Nationality of the physical person (optional)</param>
        /// <param name="numeroBanco">Bank number (optional)</param>
        /// <param name="numeroAgencia">Agency number (optional)</param>
        /// <param name="numeroContaCorrente">Current Account Number (optional)</param>
        /// <param name="email">Email of the physical person (optional)</param>
        /// <param name="nomeEmpresa">Name that must be printed on the card (optional)</param>
        /// <param name="nomeReferencia1">Name Reference 1 (optional)</param>
        /// <param name="enderecoReferencia1">Reference Address 1 (optional)</param>
        /// <param name="nomeReferencia2">Name Reference 2 (optional)</param>
        /// <param name="enderecoReferencia2">Reference Address 2 (optional)</param>
        /// <param name="naturalidadeCidade">Displays the name of the birth city of the individual (optional)</param>
        /// <param name="naturalidadeEstado">Presents the acronym of the person&#39;s state of birth (optional)</param>
        /// <param name="grauInstrucao">It shows the degree of instruction of the individual (optional)</param>
        /// <param name="numeroDependentes">Displays the number of dependents of the individual (optional)</param>
        /// <param name="nomePai">Displays the name of the parent of the individual (optional)</param>
        /// <param name="chequeEspecial">Indicates whether individual person joins the overdraft (optional)</param>
        /// <param name="impedidoFinanciamento">Flag for banks business partners that are cardholders, but cannot operate financed credit transactions (Law n. 4595/64)  (optional)</param>
        /// <returns>Task of ApiResponse (PessoaDetalheResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PessoaDetalheResponse>> Salvar_2AsyncWithHttpInfo (long? idPessoa, string nomeMae = null, long? idEstadoCivil = null, string idProfissao = null, long? idNaturezaOcupacao = null, long? idNacionalidade = null, int? numeroBanco = null, int? numeroAgencia = null, string numeroContaCorrente = null, string email = null, string nomeEmpresa = null, string nomeReferencia1 = null, string enderecoReferencia1 = null, string nomeReferencia2 = null, string enderecoReferencia2 = null, string naturalidadeCidade = null, string naturalidadeEstado = null, int? grauInstrucao = null, int? numeroDependentes = null, string nomePai = null, int? chequeEspecial = null, bool? impedidoFinanciamento = null)
        {
            // verify the required parameter 'idPessoa' is set
            if (idPessoa == null) throw new ApiException(400, "Missing required parameter 'idPessoa' when calling Salvar_2");
            
    
            var localVarPath = "/api/pessoas-detalhes";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (nomeMae != null) localVarQueryParams.Add("nomeMae", Configuration.ApiClient.ParameterToString(nomeMae)); // query parameter
            if (idEstadoCivil != null) localVarQueryParams.Add("idEstadoCivil", Configuration.ApiClient.ParameterToString(idEstadoCivil)); // query parameter
            if (idProfissao != null) localVarQueryParams.Add("idProfissao", Configuration.ApiClient.ParameterToString(idProfissao)); // query parameter
            if (idNaturezaOcupacao != null) localVarQueryParams.Add("idNaturezaOcupacao", Configuration.ApiClient.ParameterToString(idNaturezaOcupacao)); // query parameter
            if (idNacionalidade != null) localVarQueryParams.Add("idNacionalidade", Configuration.ApiClient.ParameterToString(idNacionalidade)); // query parameter
            if (numeroBanco != null) localVarQueryParams.Add("numeroBanco", Configuration.ApiClient.ParameterToString(numeroBanco)); // query parameter
            if (numeroAgencia != null) localVarQueryParams.Add("numeroAgencia", Configuration.ApiClient.ParameterToString(numeroAgencia)); // query parameter
            if (numeroContaCorrente != null) localVarQueryParams.Add("numeroContaCorrente", Configuration.ApiClient.ParameterToString(numeroContaCorrente)); // query parameter
            if (email != null) localVarQueryParams.Add("email", Configuration.ApiClient.ParameterToString(email)); // query parameter
            if (nomeEmpresa != null) localVarQueryParams.Add("nomeEmpresa", Configuration.ApiClient.ParameterToString(nomeEmpresa)); // query parameter
            if (nomeReferencia1 != null) localVarQueryParams.Add("nomeReferencia1", Configuration.ApiClient.ParameterToString(nomeReferencia1)); // query parameter
            if (enderecoReferencia1 != null) localVarQueryParams.Add("enderecoReferencia1", Configuration.ApiClient.ParameterToString(enderecoReferencia1)); // query parameter
            if (nomeReferencia2 != null) localVarQueryParams.Add("nomeReferencia2", Configuration.ApiClient.ParameterToString(nomeReferencia2)); // query parameter
            if (enderecoReferencia2 != null) localVarQueryParams.Add("enderecoReferencia2", Configuration.ApiClient.ParameterToString(enderecoReferencia2)); // query parameter
            if (naturalidadeCidade != null) localVarQueryParams.Add("naturalidadeCidade", Configuration.ApiClient.ParameterToString(naturalidadeCidade)); // query parameter
            if (naturalidadeEstado != null) localVarQueryParams.Add("naturalidadeEstado", Configuration.ApiClient.ParameterToString(naturalidadeEstado)); // query parameter
            if (grauInstrucao != null) localVarQueryParams.Add("grauInstrucao", Configuration.ApiClient.ParameterToString(grauInstrucao)); // query parameter
            if (numeroDependentes != null) localVarQueryParams.Add("numeroDependentes", Configuration.ApiClient.ParameterToString(numeroDependentes)); // query parameter
            if (nomePai != null) localVarQueryParams.Add("nomePai", Configuration.ApiClient.ParameterToString(nomePai)); // query parameter
            if (chequeEspecial != null) localVarQueryParams.Add("chequeEspecial", Configuration.ApiClient.ParameterToString(chequeEspecial)); // query parameter
            if (impedidoFinanciamento != null) localVarQueryParams.Add("impedidoFinanciamento", Configuration.ApiClient.ParameterToString(impedidoFinanciamento)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_2: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PessoaDetalheResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PessoaDetalheResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PessoaDetalheResponse)));
            
        }
        
        /// <summary>
        /// Create a register of a new Telephone This method allows to be created a new telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param> 
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param> 
        /// <param name="telefone">Telephone Number (optional)</param> 
        /// <param name="ramal">Extension Number (optional)</param> 
        /// <returns>TelefoneResponse</returns>
        public TelefoneResponse Salvar_3 (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = Salvar_3WithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a register of a new Telephone This method allows to be created a new telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param> 
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param> 
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param> 
        /// <param name="telefone">Telephone Number (optional)</param> 
        /// <param name="ramal">Extension Number (optional)</param> 
        /// <returns>ApiResponse of TelefoneResponse</returns>
        public ApiResponse< TelefoneResponse > Salvar_3WithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            
    
            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
    
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
    
            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }

        
        /// <summary>
        /// Create a register of a new Telephone This method allows to be created a new telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param>
        /// <param name="telefone">Telephone Number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <returns>Task of TelefoneResponse</returns>
        public async System.Threading.Tasks.Task<TelefoneResponse> Salvar_3Async (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
             ApiResponse<TelefoneResponse> localVarResponse = await Salvar_3AsyncWithHttpInfo(idTipoTelefone, idPessoa, ddd, telefone, ramal);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a register of a new Telephone This method allows to be created a new telephone in the database of the issuer
        /// </summary>
        /// <exception cref="Conductor.Pier.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="idTipoTelefone">Identification Code of the Telephone Type (id) (optional)</param>
        /// <param name="idPessoa">Identification Code of the Person (id) which the telephone belongs (optional)</param>
        /// <param name="ddd">DDD Code of the telephone (id) (optional)</param>
        /// <param name="telefone">Telephone Number (optional)</param>
        /// <param name="ramal">Extension Number (optional)</param>
        /// <returns>Task of ApiResponse (TelefoneResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TelefoneResponse>> Salvar_3AsyncWithHttpInfo (long? idTipoTelefone = null, long? idPessoa = null, string ddd = null, string telefone = null, string ramal = null)
        {
            
    
            var localVarPath = "/api/telefones";
    
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            
            if (idTipoTelefone != null) localVarQueryParams.Add("idTipoTelefone", Configuration.ApiClient.ParameterToString(idTipoTelefone)); // query parameter
            if (idPessoa != null) localVarQueryParams.Add("idPessoa", Configuration.ApiClient.ParameterToString(idPessoa)); // query parameter
            if (ddd != null) localVarQueryParams.Add("ddd", Configuration.ApiClient.ParameterToString(ddd)); // query parameter
            if (telefone != null) localVarQueryParams.Add("telefone", Configuration.ApiClient.ParameterToString(telefone)); // query parameter
            if (ramal != null) localVarQueryParams.Add("ramal", Configuration.ApiClient.ParameterToString(ramal)); // query parameter
            
            
            
            

            

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath, 
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams, 
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
 
            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling Salvar_3: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<TelefoneResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TelefoneResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TelefoneResponse)));
            
        }
        
    }
    
}
