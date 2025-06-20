using StyleAndCook.Entities;
using StyleAndCook.Game;

var resto1 = new Restaurant(RestaurantType.FastFood);
var resto2 = new Restaurant(RestaurantType.Pizzeria);

var player1 = new Player("Alice", resto1);
var player2 = new Player("Bob", resto2);

var game = new GameManager(player1, player2);
game.StartGame();