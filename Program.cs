using EF.Exemplo3;

using var db = new ProdutoDbContext();
if (!db.tblProdutos.Any())
{
    Console.WriteLine("Seeeding...");
    var novosDados = new List<Produto>
    {
        new() {
            ProdutoNome = "Refrigerante Guaraná Antarctica Zero Açúcar 200ml",
            ProdutoPreco = 1.43m, ProdutoEstoque = 1, ProdutoAtivo = true },
        new() {
            ProdutoNome = "Água Tônica Zero Açúcar Schweppes Lata 220ml",
            ProdutoPreco = 1.99m, ProdutoEstoque = 1, ProdutoAtivo = true },
        new() {
            ProdutoNome = "Suco Pronto Maguary Laranja 1L",
            ProdutoPreco = 5.70m, ProdutoEstoque = 1, ProdutoAtivo = true },
        new() {
            ProdutoNome = "Linguiça Toscana Aurora Pacote 800g",
            ProdutoPreco = 13.94m, ProdutoEstoque = 1, ProdutoAtivo = true },
        new() {
            ProdutoNome = "Manteiga Aviação com Sal 500g Pote",
            ProdutoPreco = 32.65m, ProdutoEstoque = 1, ProdutoAtivo = true },
        new() {
            ProdutoNome = "Amaciante Ypê Aconchego 2 Litros",
            ProdutoPreco = 9.59m, ProdutoEstoque = 1, ProdutoAtivo = true },
    };
    db.AddRange(novosDados);
    db.SaveChanges();
    Console.WriteLine("Done!");
}
