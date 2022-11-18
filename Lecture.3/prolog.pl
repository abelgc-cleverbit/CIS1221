% use swipl to interactively run this file
% use [prolog]. to load the definitions in this file

% example 1
% fact list 
weather(havana, summer, hot).
weather(valletta, summer, hot).
weather(valletta, spring, warm).
weather(oslo, summer, warm).
weather(artic, summer, cold).
weather(rome, winter, cold).
% try: 
% - weather(City, _, hot). 
% - weather(City, summer, hot), weather(City, spring, warm).
% - findall(City, weather(City,_,hot), L).


% example 2
% multiply example
multiply(X,Y,Z) :- number(X),number(Y),Z is X * Y.
% try:
% - multiply(5,4,X).

multiply(X,Y,Z) :- number(X),number(Z),X \= 0,Y is Z / X.
multiply(X,Y,Z) :- number(Y),number(Z),Y \= 0,X is Z / Y.
% uncomment the 2 lines above and try:
% - multiply(5, X, 35).
% - multiply(5, X, 32).
