programa
{
	
	funcao inicio()
	{
		inteiro idade

		escreva("Digite sua Idade: ")
		leia(idade)

		se (idade <18)
		{
			escreva ("Você é Menor de Idade.")
		}
		senao se(idade >= 18 e idade < 65)
		{
			escreva("Você é Adulto.")
		}
		senao
		{
			escreva("Você é Idoso.")
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 292; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */