"use strict";

//Task1

function sum(a) {

  var currentSum = a;

  function result(b) {
    currentSum += b;
    return result;
  }

  result.toValue = function() {
    return currentSum;
  };
  
  result.toString = function() {
    return currentSum;
  };

  return result;
}

alert( sum(1)(2) ); // 3
alert( sum(5)(-1)(2) ); // 6
alert( sum(6)(-1)(-2)(-3) ); // 0
alert( sum(0)(1)(2)(3)(4)(5) ); // 15