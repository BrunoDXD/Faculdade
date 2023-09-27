programa
{
	inclua biblioteca Arquivos --> cad
	funcao inicio()
	{

	     inteiro arquivo = cad.abrir_arquivo("./Dados.txt", cad.MODO_ESCRITA)
		cadeia nome
		inteiro idade

		escreva ("Digite seu nome: ")
		leia(nome)

		cad.escrever_linha("Nome: "+nome, arquivo)

		escreva ("Digite sua Idade: ")
		leia(idade)

		cad.escrever_linha("Idade: "+idade, arquivo)

		cad.fechar_arquivo(arquivo)

		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 407; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */