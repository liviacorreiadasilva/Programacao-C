using System;
using System.Collections.Generic;

// o Using significa acesso, ou seja, ele permite acesso de algo. por exemplo, em "using sytem" significa que ele está permitindo o uso do "system", para que o system funcione corretamente
// O System é  um indicador de acesso, ou seja, ele permite que o meu codigo acesse e utilize  os nembros do namespace como classes,funções metodos, heranças e e outros que teram no codigo.
// O  System.Collections.Generic é uma biblioteca  usada  para fornecer uma estrutura de dados especiais para armazenar e organizar os elementos do mesmo tipo, como: 
// list (lista ordenada que é acessada por um indice que pode armazenar qualquer tipo de dado); Dicionary<key,value> (Dicionário que irá mapear chaves únicas para valores, 
//permitindo um  acesso rápido por chave); 

// NameSpace é um organizador na estrutura do codigo, como se fossem uma  como pastas dentro de uma biblioteca. Cada pasta contém elementos relacionados, como classes que manipulam strings, funções matemáticas ou variáveis que armazenam configurações do programa.
// Resumindo, o namespace é um organizador de estrutura do codigo, ou seja, ele que irá organizar as funções, classes , herenças e variaveis que ficam armazenada  na configuração do programa , oun seja a name espace que vai armazenar todas as classes, funçoes etc.
class TabelaCRUD
{
    // - static List<Dictionary<string, string>> tabela = new List<Dictionary<string, string>>(); : é uma variável que declaramos que será usada para armazenar os registros de usuários (nome, idade e telefone) ao longo da execução do programa.//
    
    static List < Dictionary<string, string>>tabela = new List<Dictionary<string, string>>();
    
    // - tabela = new List<Dictionary<string, string>>(); :  tabela é o nome da variavel que declaramos, para representar uma tabela de dados. Cada entrada (letras e numeros digitados) é um dicionário contendo informações sobre um usuário.//
    // - List<Dictionary<string, string>>: declaramos essa instancia para criar uma nova lista vazia para adicionar novos dicionarios dentro da  variavel tabela//
    // - List <Dictionary<string, string>>: declaração do tipo da variável tabela, especificando que a tabela é uma lista que possui um dicionario em que as chaves e valores são do tipo string //
    
    

    
    static void Main()
    {
        while (true)
        {
    // mensagem que aparecerá no console ao usuario quando iniciar o programa //
            Console.WriteLine("\nDigite um comando desejado : ('adicionar', 'ver tabela', 'buscar nome', 'excluir usuario' ou 'sair'):");
            string comando = Console.ReadLine().ToLower();

            switch (comando)
            {
                case "adicionar":
                    AdicionarUsuario();
                    break;
                case "ver tabela":
                    VerTabela();
                    break;
                case "buscar pelo nome":
                    BuscarNome();
                    break;
                case "excluir usuario":
                    ExcluirUsuario();
                    break;
                case "sair":
                    return;
                default:
            // mensagem que aparecerá no console ao usuario quando iniciar o programa //
                    Console.WriteLine("Comando inválido. Tente novamente.");
                    break;
            }
        }
    }
    
// declaração do metodo Adicionar Usuario//
    static void AdicionarUsuario()
    {
        // mensagem que aparecerá no console ao usuario quando iniciar o programa //
        Console.WriteLine("Digite um nome de usuario para adicionar:");
        // Lê a entrada do usuário do console e armazena em 'nome' //
        string nome = Console.ReadLine();

        // mensagem que aparecerá no console ao usuario quando iniciar o programa //
        Console.WriteLine("Digite a idade do usuario:");
        // Lê a entrada do usuário do console e armazena em 'idade' //
        string idade = Console.ReadLine();

        // mensagem que aparecerá no console ao usuario quando iniciar o programa //
        Console.WriteLine("Digite o telefone do usuario:");
        // Lê a entrada do usuário do console e armazena em 'telefone' //
        string telefone = Console.ReadLine();


// a idade e telefone está como tipo string porque é uma sequencia de digitos para validação. se o telefone e idade fossem usadas para realizar um calculo o tipo seria int//
 // - Dicionary : o dicionario ou dicionary é uma estrutura usada para armazenar todos os dados que sera digitados e salvos na tabela do tipo string (nome,idade e telefone //
        Dictionary<string, string> usuario = new Dictionary<string, string>();
        // a primeira string no dicionary se refere a "Nome","Idade" e "Telefone" (chaves) //
        // a segunda string no dicionary se refere a nome,idade e telefone (tipo de dado dos valores associados as chaves,) //  
// o "Nome" é a chave, e nome é a variavel valor que armazenará a entrada de um nome digitado ( e assim o mesmo para idade e telefone) //
  
  
  // - Dictionary<string, string>usuario :  usado apenas declara uma variável do tipo dicionário//
  //-  new Dictionary<string, string>() : usado para cria uma nova instância de um dicionário vazio//
        usuario.Add("Nome", nome);
        usuario.Add("Idade", idade);
        usuario.Add("Telefone", telefone);

// adiciona o dicionário usuario à lista tabela, ou seja, estamos adicionando um novo usuário à nossa "tabela"//
        tabela.Add(usuario);
// quando o usuario for adicionado na tabela corretamente, o console mostrará essa mensagem para o usuario//
        Console.WriteLine("Usuário adicionado na tabela com sucesso.");
    }
    
// declaração do metodo ver tabela//
    static void VerTabela()
    {
        //declaramos a condição para verificar se a contagem de elementos na lista tabela é igual a zero
        // - Count : é uma propriedade da lista que usamos para retornar o número de elementos na lista
        if (tabela.Count == 0)
        {
            // mensagem que aparecerá no console ao usuario digitar um nome que não esteja cadastrado na tabela //
            Console.WriteLine("A tabela está vazia.");
            return;
        }
        // imprimira uma linha de texto no console com as informações de nome,idade e telefone// 
        Console.WriteLine("Nome\tIdade\tTelefone");

// - foreach é um loop usado para percorrer cada elemento da lista tabela em sequência(um de cada vez)//
      //  foreach (var usuario in tabela) é um loop para rodar cada elemento (um de cada vez) da variavel usuario da lista tabela//  
        foreach (var usuario in tabela)
        
    //usuario no foreach - é o nome da variável que será usada para armazenar cada elemento da lista tabela//
        {
            // mensagem que aparecerá no console ao usuario quando escolher a opcao ver tabela //
            Console.WriteLine($"{usuario["Nome"]}\t{usuario["Idade"]}\t{usuario["Telefone"]}");
        }
    }
// declaração do metodo buscar nome //
    static void BuscarNome()
    {// mensagem que aparecerá no console ao usuario quando escolher a opcao de Buscar Nome //
        Console.WriteLine("Digite o nome do usuario que deseja buscar na tabela:");
    // Lê a entrada do usuário do console e armazena em 'nome' //
        string nome = Console.ReadLine();

        foreach (var usuario in tabela)
        {
            if (usuario["Nome"].Equals(nome, StringComparison.OrdinalIgnoreCase))
            {
                // mensagem que aparecerá no console ao usuario quando escrever o nome que deseja buscar na tabela //
                Console.WriteLine($"Idade: {usuario["Idade"]}, Telefone: {usuario["Telefone"]}");
                return;
            }
        }
        // mensagem que aparecerá no console ao usuario quando o nome não for encontrado ao buscar na tabela //
        Console.WriteLine($"Usuário '{nome}' não encontrado na tabela.");
    }
// declaração do metodo excluir usuario //
    static void ExcluirUsuario()
    {
        // mensagem que aparecerá no console ao usuario quando escolher a opcao Excluir Usuario //
        Console.WriteLine("Digite o nome do usuário que deseja excluir:");
        // Lê a entrada do usuário do console e armazena em 'nome' //
        string nome = Console.ReadLine();

//Inicia um loop ( for + if )para iterar sobre cada dicionário (representando um usuário) na lista //
        for (int i = 0; i < tabela.Count; i++)
        {
           // Verifica se o nome do usuário no dicionário é igual ao nome digitado pelo usuário, ignorando a diferenciação de maiúsculas e minúsculas. //
            if (tabela[i]["Nome"].Equals(nome, StringComparison.OrdinalIgnoreCase)) 
            {
            // Se o nome digitado  for encontrado, removerá o usuário correspondente da tabela.//
                tabela.RemoveAt(i);
            // ao encontrar o nome digitado para excluir, aparecera  uma mensagem no console informando que o usuário foi excluído com sucesso. //
                Console.WriteLine($"Usuário '{nome}' excluído com sucesso.");
                return;
            }
        }
        // mensagem que aparecerá no console ao usuario quando o nome de usuario não for encontrado //
        Console.WriteLine($"Usuário '{nome}' não encontrado na tabela.");
    }
}
