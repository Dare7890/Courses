"use strict";

//Task1

function work(a) {
  /* ... */ // work - произвольная функция, один аргумент
}

function makeLogging(f, log) {
	function logger(arg) {
      log.push(arg);
      return f.call(this, arg);
    }
	return logger;
}

var log = [];
work = makeLogging(work, log);

work(1); // 1, добавлено в log
work(5); // 5, добавлено в log

for (var i = 0; i < log.length; i++) {
  alert( 'Лог:' + log[i] ); // "Лог:1", затем "Лог:5"
}

//Task2

function work(a, b) {
  alert( a + b ); // work - произвольная функция
}

function makeLogging(f, log) { 
	function logger() {
		arguments.slice = [].slice;
		log.push(arguments.slice.call(arguments));
		return f.apply(this, arguments);
    }
	return logger;
}

var log = [];
work = makeLogging(work, log);

work(1, 2); // 3
work(4, 5); // 9

for (var i = 0; i < log.length; i++) {
  var args = log[i]; // массив из аргументов i-го вызова
  alert( 'Лог:' + args.join() ); // "Лог:1,2", "Лог:4,5"
}