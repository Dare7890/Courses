"use strict";

//Task2
var nameOfJS = prompt("Каково «официальное» название JavaScript?", '');

if (nameOfJS == "ECMAScript"){
	alert("Верно!");
}
else
{
	alert("Не знаете? «ECMAScript»!");
}

//Task3

var value = prompt("Введите любое значение", '');

if (value > 0)
{
	alert(1);
} else if (value == 0)
{
	alert(0);
} else
{
	alert(-1);
}

//Task4

var userName = prompt('Кто пришёл?', '');

if (userName == 'Админ')
	{
  var pass = prompt('Пароль?', '');
  if (pass == 'Чёрный Властелин') 
  {
    alert( 'Добро пожаловать!' );
  } else if (pass == null)
	  {
    alert( 'Вход отменён' );
  } else
	  {
    alert( 'Пароль неверен' );
  }
} else if (userName == null)
	{ 
  alert( 'Вход отменён' );
} else
	{
  alert( 'Я вас не знаю' );
}

//Task5

// var result = (a + b < 4) ? 'Мало' : 'Много';
// alert(result);

//Task6

// var message = (login == 'Вася') ? 'Привет' :
  // (login == 'Директор') ? 'Здравствуйте' :
  // (login == '') ? 'Нет логина' : '';