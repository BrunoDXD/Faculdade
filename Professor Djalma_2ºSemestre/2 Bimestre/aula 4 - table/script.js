function CriarCampos(){
    const container = document.getElementById('conteudo');
    const CaixaTexto = document.createElement('input');
    CaixaTexto.type = 'text';
    CaixaTexto.id = 'txtcaixa1';
    CaixaTexto.name = 'txtcaixa1';
    CaixaTexto.placeholder = 'Caixa de Texto 1';
    container.appendChild(CaixaTexto);

    const CaixaTexto2 = document.createElement('input');
    CaixaTexto2.type = 'text';
    CaixaTexto2.id = 'txtcaixa2';
    CaixaTexto2.name = 'txtcaixa2';
    CaixaTexto2.placeholder = 'Caixa de Texto 2';
    container.appendChild(CaixaTexto2);

    const botao = document.createElement('input');
    botao.type = 'button';
    botao.id = 'button1';
    botao.name = 'button1';
    botao.value = 'ENVIAR';
    container.appendChild(botao);

}

function CriarTabela(){
    const tabela = document.getElementById('tabela');
    let tabelaHTML = '<table border ="1">';

    tabelaHTML+= '<tr>';
    tabelaHTML+= '<th>Nome</th>';
    tabelaHTML+= '<th>CPF</th>';
    tabelaHTML+= '<th>Telefone</th>';
    tabelaHTML+= '</tr>';

    tabelaHTML+= '<tr>';
    tabelaHTML+= '<td>João</td>';
    tabelaHTML+= '<td>000.000.000-00</td>';
    tabelaHTML+= '<td>(11) 9 9876-5432</td>';
    tabelaHTML+= '</tr>';

    tabelaHTML+= '<tr>';
    tabelaHTML+= '<td>Maria</td>';
    tabelaHTML+= '<td>111.111.111-11</td>';
    tabelaHTML+= '<td>(11) 9 1234-5678</td>';
    tabelaHTML+= '</tr>';

    tabelaHTML+= '</table>';
    tabela.innerHTML = tabelaHTML;
}

