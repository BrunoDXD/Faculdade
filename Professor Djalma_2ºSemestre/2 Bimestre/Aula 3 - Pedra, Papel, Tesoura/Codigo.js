const opcoes = ["Pedra", "Papel", "Tesoura"];
var escolhaPc = opcoes[Math.floor(Math.random()* opcoes.length)];
var escolhaJogador = "0";

function escolha(escolha)
{
    escolhaJogador = escolha;  

    
    if (escolhaJogador === "Pedra" && escolhaPc === "Papel"){
        document.getElementById("txtresultado").value="Máquina!";
        document.getElementById("txtescolhapc").value=escolhaPc;
        document.getElementById("txtescolhajogador").value=escolhaJogador;
    }
    else if (escolhaJogador === "Papel" && escolhaPc === "Pedra"){
        document.getElementById("txtresultado").value="Você Venceu!";
        document.getElementById("txtescolhapc").value=escolhaPc;
        document.getElementById("txtescolhajogador").value=escolhaJogador;
    }
    else if (escolhaJogador === "Pedra" && escolhaPc === "Tesoura"){
        document.getElementById("txtresultado").value="Você Venceu!";
        document.getElementById("txtescolhapc").value=escolhaPc;
        document.getElementById("txtescolhajogador").value=escolhaJogador;
    }
    else if (escolhaJogador === "Tesoura" && escolhaPc === "Pedra"){
        document.getElementById("txtresultado").value="Máquina!";
        document.getElementById("txtescolhapc").value=escolhaPc;
        document.getElementById("txtescolhajogador").value=escolhaJogador;
    }
    else if (escolhaJogador === "Papel" && escolhaPc === "Tesoura"){
        document.getElementById("txtresultado").value="Máquina!";
        document.getElementById("txtescolhapc").value=escolhaPc;
        document.getElementById("txtescolhajogador").value=escolhaJogador;
    }
    else if (escolhaJogador === "Tesoura" && escolhaPc === "Papel"){
        document.getElementById("txtresultado").value="Você Venceu!";
        document.getElementById("txtescolhapc").value=escolhaPc;
        document.getElementById("txtescolhajogador").value=escolhaJogador;
    }
    else
    {
        document.getElementById("txtresultado").value="Empate!";
        document.getElementById("txtescolhapc").value=escolhaPc;
        document.getElementById("txtescolhajogador").value=escolhaJogador;
    }
    escolhaPc = opcoes[Math.floor(Math.random()* opcoes.length)];
}

function limpa(){
    document.getElementById("txtresultado").value="";
    document.getElementById("txtescolhapc").value="";
    document.getElementById("txtescolhajogador").value="";
}
