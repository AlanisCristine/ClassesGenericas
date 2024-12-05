using ClassesGenericas;

//MinhaClasseGenerica<int> minhaClasse = new MinhaClasseGenerica<int>(10);
//Console.WriteLine(minhaClasse.ObterValor());

//MinhaClasseGenerica<string> minhaClasse2 = new MinhaClasseGenerica<string>("Alanis");
//Console.WriteLine(minhaClasse2.ObterValor());
//minhaClasse2.MostrarTipo();

//ListaGenerica<int> ListaDeInteiro = new ListaGenerica<int>();
//ListaDeInteiro.Adicionar(1);
//ListaDeInteiro.Adicionar(2);
//ListaDeInteiro.MostrarItens();


//ListaGenerica<Pessoa> ListaDePessoas = new ListaGenerica<Pessoa>();
//ListaDePessoas.Adicionar(new Pessoa() { Id = 1, Nome = "Alanis"});
//ListaDePessoas.Adicionar(new Pessoa() { Id = 2, Nome = "Pérola" });
//ListaDePessoas.MostrarItens();

Pilha<int> pi = new Pilha<int>();
pi.Push(1);
pi.Push(2);
pi.Push(3);
pi.MostrarItens();
pi.Pop();
pi.MostrarItens();