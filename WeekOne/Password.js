//Made by Gustavoufjfjv1 - Gustavo Henrique

let caracteres = "1 2 3 4 5 6 7 8 9 0 q w e r t y u i o p a s d f g h j k l ç z x c v b n m Q W E R T Y U I O P A S D F G H J K L Ç Z X C V B N M ! @ # $ & * ? _ -"

let array = caracteres.split(' ')

let senha = "";

for(let i = 0; i < 8; i++){
  let novoCaractere;
  do {
    novoCaractere = array[Math.floor(Math.random() * array.length)];
  } while (senha.length > 0 && novoCaractere === senha[senha.length - 1]);
  senha += novoCaractere;
}

console.log(senha)
