using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Conductor.Pier.Model
{
    /// <summary>
    /// Objeto de resposta para favoritos de recarga de celular 
    /// </summary>
    [DataContract]
    public partial class RecargaCelularFavoritoResponse :  IEquatable<RecargaCelularFavoritoResponse>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecargaCelularFavoritoResponse" /> class.
        /// Initializes a new instance of the <see cref="RecargaCelularFavoritoResponse" />class.
        /// </summary>
        /// <param name="Ativo">Indicador de status do favorito.</param>
        /// <param name="DddCelular">N\u00FAmero DDD do favorito.</param>
        /// <param name="Id">Identificador do favorito.</param>
        /// <param name="IdConta">Identificador da conta.</param>
        /// <param name="Nome">Nome do favorito.</param>
        /// <param name="NumeroCelular">N\u00FAmero do celular do favorito.</param>

        public RecargaCelularFavoritoResponse(bool? Ativo = null, string DddCelular = null, long? Id = null, long? IdConta = null, string Nome = null, string NumeroCelular = null)
        {
            this.Ativo = Ativo;
            this.DddCelular = DddCelular;
            this.Id = Id;
            this.IdConta = IdConta;
            this.Nome = Nome;
            this.NumeroCelular = NumeroCelular;
            
        }
        
    
        /// <summary>
        /// Indicador de status do favorito
        /// </summary>
        /// <value>Indicador de status do favorito</value>
        [DataMember(Name="ativo", EmitDefaultValue=false)]
        public bool? Ativo { get; set; }
    
        /// <summary>
        /// N\u00FAmero DDD do favorito
        /// </summary>
        /// <value>N\u00FAmero DDD do favorito</value>
        [DataMember(Name="dddCelular", EmitDefaultValue=false)]
        public string DddCelular { get; set; }
    
        /// <summary>
        /// Identificador do favorito
        /// </summary>
        /// <value>Identificador do favorito</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long? Id { get; set; }
    
        /// <summary>
        /// Identificador da conta
        /// </summary>
        /// <value>Identificador da conta</value>
        [DataMember(Name="idConta", EmitDefaultValue=false)]
        public long? IdConta { get; set; }
    
        /// <summary>
        /// Nome do favorito
        /// </summary>
        /// <value>Nome do favorito</value>
        [DataMember(Name="nome", EmitDefaultValue=false)]
        public string Nome { get; set; }
    
        /// <summary>
        /// N\u00FAmero do celular do favorito
        /// </summary>
        /// <value>N\u00FAmero do celular do favorito</value>
        [DataMember(Name="numeroCelular", EmitDefaultValue=false)]
        public string NumeroCelular { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecargaCelularFavoritoResponse {\n");
            sb.Append("  Ativo: ").Append(Ativo).Append("\n");
            sb.Append("  DddCelular: ").Append(DddCelular).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdConta: ").Append(IdConta).Append("\n");
            sb.Append("  Nome: ").Append(Nome).Append("\n");
            sb.Append("  NumeroCelular: ").Append(NumeroCelular).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RecargaCelularFavoritoResponse);
        }

        /// <summary>
        /// Returns true if RecargaCelularFavoritoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RecargaCelularFavoritoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecargaCelularFavoritoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Ativo == other.Ativo ||
                    this.Ativo != null &&
                    this.Ativo.Equals(other.Ativo)
                ) && 
                (
                    this.DddCelular == other.DddCelular ||
                    this.DddCelular != null &&
                    this.DddCelular.Equals(other.DddCelular)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.IdConta == other.IdConta ||
                    this.IdConta != null &&
                    this.IdConta.Equals(other.IdConta)
                ) && 
                (
                    this.Nome == other.Nome ||
                    this.Nome != null &&
                    this.Nome.Equals(other.Nome)
                ) && 
                (
                    this.NumeroCelular == other.NumeroCelular ||
                    this.NumeroCelular != null &&
                    this.NumeroCelular.Equals(other.NumeroCelular)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Ativo != null)
                    hash = hash * 59 + this.Ativo.GetHashCode();
                
                if (this.DddCelular != null)
                    hash = hash * 59 + this.DddCelular.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.IdConta != null)
                    hash = hash * 59 + this.IdConta.GetHashCode();
                
                if (this.Nome != null)
                    hash = hash * 59 + this.Nome.GetHashCode();
                
                if (this.NumeroCelular != null)
                    hash = hash * 59 + this.NumeroCelular.GetHashCode();
                
                return hash;
            }
        }

    }
}
