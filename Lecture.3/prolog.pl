% use swipl to interactively run this file
% use [prolog]. to load the definitions in this file

% Prolog clauses can be facts, rules, or queries.
% Facts are basic assertions about some information.
% Rules are conditional statements that define relationships between facts.
% Queries are questions asked to the Prolog system to retrieve information based on the defined facts and rules.

% example 1
% fact list 
% Facts about the weather in different cities during different seasons
% weather(havana, summer, hot).
% weather(valletta, summer, hot).
% weather(valletta, spring, warm).
% weather(oslo, summer, warm).
% weather(artic, summer, cold).
% weather(rome, winter, cold).

% Queries to try:
% - weather(City, _, hot). 
%   This query asks for all cities where the weather is hot in any season.
% - weather(City, summer, hot), weather(City, spring, warm).
%   This query asks for cities where the weather is hot in summer and warm in spring.
% - findall(City, weather(City,_,hot), L).
%   This query finds all cities where the weather is hot and returns them in a list L.

% example 2
% multiply example
% Rule to multiply two numbers
multiply(X, Y, Z) :- number(X), number(Y), Z is X * Y.

% Queries to try:
% - multiply(5, 4, X).
%   This query calculates the product of 5 and 4 and returns the result in X.

% Additional rules to handle division
multiply(X, Y, Z) :- number(X), number(Z), X \= 0, Y is Z / X.
multiply(X, Y, Z) :- number(Y), number(Z), Y \= 0, X is Z / Y.

% Uncomment the 2 lines above and try:
% - multiply(5, X, 35).
%   This query calculates the value of X such that 5 * X = 35.
% - multiply(5, X, 32).
%   This query calculates the value of X such that 5 * X = 32.
