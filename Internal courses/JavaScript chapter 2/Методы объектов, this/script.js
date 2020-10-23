"use strict";

//Task1

var calculator = {
	var a, b;
	
	function read(){
		this.a = +prompt('Введите значение a', '');
		this.b = +prompt('Введите значение b', '');
	}
	
	function sum(){
		return this.a + this.b;
	}
	
	function mult(){
		return this.a * this.b;
	}
}

calculator.read();
alert( calculator.sum() );
alert( calculator.mul() );

//Task2

var ladder = {
  step: 0,
  up: function() { // вверх по лестнице
    this.step++;
	return this;
  },
  down: function() { // вниз по лестнице
    this.step--;
	return this;
  },
  showStep: function() { // вывести текущую ступеньку
    alert( this.step );
	return this;
  }
};

ladder.up().up().down().up().down().showStep(); // 1