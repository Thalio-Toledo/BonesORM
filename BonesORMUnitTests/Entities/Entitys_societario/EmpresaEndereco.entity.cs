using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BonesCore.DataAnotattions;

namespace BonesORMUnitTests.Entities.Entitys_societario;

[Table("ControlePermissao..TB_EMPRESA_ENDERECO")]
public class EmpresaEndereco
{
    [Key]
    public int Id { get; set; }

    [ForeignkeyOf("Empresa")]
    public int IdEmpresa { get; set; }
    public Empresa Empresa { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string complemento { get; set; }
    public string Bairro { get; set; }
    public string CEP { get; set; }

    [ForeignkeyOf("Municipio")]
    public int IdMunicipio { get; set; }
    public Municipio Municipio { get; set; }
    public bool ativo { get; set; }
    public int idAuxEmpresaEnderecoTipo { get; set; }
}
