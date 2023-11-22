/*Calculadora aula 2
function Somar() {
    let numero1 = document.getElementById("txtNumero1").value;
    let numero2 = document.getElementById("txtNumero2").value;
    let resultado = parseFloat(numero1) + parseFloat(numero2);
    document.getElementById("txtResultado").value = resultado;

    
}
function Subtrair() {
    let numero1 = document.getElementById("txtNumero1").value;
    let numero2 = document.getElementById("txtNumero2").value;
    let resultado = parseFloat(numero1) - parseFloat(numero2);
    document.getElementById("txtResultado").value = resultado;

    
}
function Multiplicar() {
    let numero1 = document.getElementById("txtNumero1").value;
    let numero2 = document.getElementById("txtNumero2").value;
    let resultado = parseFloat(numero1) * parseFloat(numero2);
    document.getElementById("txtResultado").value = resultado;

    
}
function Dividir() {
    let numero1 = document.getElementById("txtNumero1").value;
    let numero2 = document.getElementById("txtNumero2").value;

    if (numero2 == 0){
        alert("Não Existe Divisão por ZERO!!!")
    } else{
    let resultado = parseFloat(numero1) / parseFloat(numero2);
    document.getElementById("txtResultado").value = resultado;
    }
    
}
*/

function Iniciar(){
    var valor='0';
    getElementById('txtVisor').value=valor;
}

function btn0(){
    valor+='0';
    document.getElementById('txtVisor').value=valor;
}
function btn1(){
    valor+='1';
    document.getElementById('txtVisor').value=valor;
}
function btn2(){
    valor+='2';
}
function btn3(){
    valor+='3';
}
function btn4(){
    valor+='4';
}
function btn5(){
    valor+='5';
}
function btn6(){
    valor+='6';
}
function btn7(){
    valor+='7';
}
function btn8(){
    valor+='8';
}
function btn9(){
    valor+='9';
}

