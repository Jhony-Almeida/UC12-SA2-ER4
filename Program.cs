// See https://aka.ms/new-console-template for more information

//Console.Clear();
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Turma13");

using ProgBackEnd.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novaEndPF = new Endereco();

novaPf.nome = "Jhony Almeida da Silva";
novaPf.cpf = "1547846565";
novaPf.rendimento = 7000.5f;
novaPf.dataNasc = new DateTime(1979,01,01);

// Console.WriteLine($"Pessoa Fisica ========================");
// float resultado = novaPf.CalcularImposto(novaPf.rendimento);
// Console.WriteLine(resultado);
// Console.WriteLine($"Validação de Datas ========================");
// DateTime temp = new DateTime(2000,01,01);
// //Console.WriteLine(novaPf.ValidarDataNasc(temp));
// Console.WriteLine(novaPf.ValidarDataNasc("01/01/2000"));

novaEndPF.logradouro = "Rua Niteroi";
novaEndPF.numero = 100;
novaEndPF.complemento = "Predio";
novaEndPF.endComercial = true;

novaPf.endereco = novaEndPF;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Nome da Rua: {novaPf.endereco.logradouro}, Num: {novaPf.endereco.numero}
Maior de Idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");





// Console.WriteLine($"Pessoa Juridica ========================");
// float impostoPagar = novaPj.CalcularImposto(12000.5f);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine($"{impostoPagar.ToString("C")}");


//Console.WriteLine(novaPf.nome);
//Console.WriteLine(novaPf.cpf);
//Console.WriteLine($"---------------------------");


//Console.WriteLine($"Bem-vindo {novaPf.nome} seu cpf é:{novaPf.cpf}");