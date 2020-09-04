

using System.ComponentModel.DataAnnotations;

namespace lanches.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }
        [StringLength(200)]

        public decimal Preco { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [Display(Name = "Imagem")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Lanche Preferido")]
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}



















