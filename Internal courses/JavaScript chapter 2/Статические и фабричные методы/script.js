"use strict";

//Task1


function Article() {
  this.created = new Date();
  Article.count++;
  Article.lastCreate = this.created;
}
  Article.count = 0;
  
  Article.showStats = function(){
	  alert("Количество объектов: " + this.count + ". Последняя запись " + this.lastCreate);
  }

new Article();
new Article();

Article.showStats(); // Всего: 2, Последняя: (дата)

new Article();

Article.showStats(); // Всего: 3, Последняя: (дата)