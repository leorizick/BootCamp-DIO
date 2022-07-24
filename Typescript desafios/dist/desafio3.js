let botaoAtualizar = document.getElementById('atualizar-saldo');
let botaoLimpar = document.getElementById('limpar-saldo');
let soma = document.getElementById('soma');
let campoSaldo = document.getElementById('campo-saldo');
let total = 0;
limparSaldo();
function somarAoSaldo(soma) {
    if (campoSaldo) {
        total += soma;
        campoSaldo.innerHTML = total.toString();
        limparCampoSoma();
    }
}
function limparCampoSoma() {
    soma.value = "";
}
function limparSaldo() {
    if (campoSaldo) {
        total = 0;
        campoSaldo.innerHTML = total.toString();
    }
}
botaoAtualizar.addEventListener("click", () => {
    somarAoSaldo(Number(soma.value));
});
botaoLimpar.addEventListener('click', () => {
    limparSaldo();
});
let a = 0;
function fun(param) {
    param += 5;
}
fun(a);
console.log(a);
export {};
