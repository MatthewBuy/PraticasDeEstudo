
function calcular(){
    var n1 = Number(document.getElementById("nota1").value);
    var n2 = Number(document.getElementById("nota2").value);
    var n3 = Number(document.getElementById("nota3").value);
    var n4 = Number(document.getElementById("nota4").value);

    var media = (n1 + n2 + n3 + n4) / 4
    

    if(media >= 7){
        document.getElementById("cad_nota").innerHTML =  "Sua média é de: " + media + " parabens, voce passou";
        document.getElementById("img").src="imagens/feliz.jpg"
    }else{
        document.getElementById("cad_nota").innerHTML =  "Sua média é de: " + media + " voce está reprovado";
        document.getElementById("img").src="imagens/triste.jpg"
    }


}
