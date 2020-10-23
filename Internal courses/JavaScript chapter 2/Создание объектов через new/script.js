"use strict";

//Task1

function Calculator(){
	
	this.read = function(){
		this.a = +prompt('Введите значение a', '');
		this.b = +prompt('Введите значение b', '');
	}
	
	this.sum = function(){
		return this.a + this.b;
	}
	
	this.mul = function(){
		return this.a * this.b;
	}
}

var calculator = new Calculator();
calculator.read();

alert( "Сумма=" + calculator.sum() );
alert( "Произведение=" + calculator.mul() );

//Task2 

function Accumulator(startingValue){
	this.value = startingValue;
	
	this.read = function(){
		return this.value += +prompt("Введите число", '');
	}
}

var accumulator = new Accumulator(1); // начальное значение 1
accumulator.read(); // прибавит ввод prompt к текущему значению
accumulator.read(); // прибавит ввод prompt к текущему значению
alert( accumulator.value ); // выведет текущее значение