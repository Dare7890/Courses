"use strict";

//Task1

function makeSum(a){
	return function (b){
		return a + b;
	}
}

alert( makeSum(2)(3) );

//Task2-3

function makeBuffer() { 
	var buff = '';
	
	return function buffer(value){
		if (arguments.length == 0) 
		{
		return buff;
		}
		else{
		buff += value + ' ';
		}
		
		buffer.clear = function(){
			buff = ' ';
		}
	}
}

var buffer = makeBuffer();

// добавить значения к буферу
buffer('Замыкания');
buffer(' Использовать');
buffer(' Нужно!');

// получить текущее значение
alert( buffer() ); // Замыкания Использовать Нужно!

buffer.clear();

alert( buffer() );


//Task4

function byField(field){
	return function(a, b){
		return a[field] > b[field] ? 1 : -1;
	}
}

var users = [{
  name: "Вася",
  surname: 'Иванов',
  age: 20
}, {
  name: "Петя",
  surname: 'Чапаев',
  age: 25
}, {
  name: "Маша",
  surname: 'Медведева',
  age: 18
}];

users.sort(byField('name'));
users.forEach(function(user) {
  alert( user.name );
}); // Вася, Маша, Петя

users.sort(byField('age'));
users.forEach(function(user) {
  alert( user.name );
}); // Маша, Вася, Петя

//Task5

function filter(arr, func){
	var arrResult = [];
	
	arr.forEach(function (el){
		if (func(el))
			arrResult.push(el);
	});
	return arrResult;
}

function inBetween(a,b){
	return function(number){
		if ((number >= a) && (number <= b))
			return number;
	}
}

function inArray(arr){
	return function(number){
		if (arr.indexOf(number) != 0)
			return arr.indexOf(number);
	}
}

var arr = [1, 2, 3, 4, 5, 6, 7];

alert(filter(arr, function(a) {
  return a % 2 == 0
})); // 2,4,6

alert( filter(arr, inBetween(3, 6)) ); // 3,4,5,6

alert( filter(arr, inArray([1, 2, 10])) ); // 1,2

//Task6

function makeArmy() {

  var shooters = [];

  
  for (var i = 0; i < 10; i++) {
    var shooter = function func() { // функция-стрелок
      alert( func.i ); // выводит свой номер
    };
	shooter.i = i;
    shooters.push(shooter);
  }

  return shooters;
}

var army = makeArmy();

army[0](); // стрелок выводит 10, а должен 0
army[5](); // стрелок выводит 10...